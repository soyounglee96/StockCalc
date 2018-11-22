using System;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using StockCalc.Data;
using StockCalc.Data.Data;
using StockCalc.Gui.UserControl;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using StockData = StockCalc.Data.Data.StockData;


namespace StockCalc.Gui
{
    public partial class Form1 : Form
    {
        WebClient web = new WebClient();



        public Form1()
        {
            InitializeComponent();
        }


        private void sise_market_Data1()
        {
            Price price = new Price();
            PriceData priceData = new PriceData();
            StockData stockData = new StockData();
            

            HtmlDocument document;
            web.Encoding = Encoding.Default;

            //시총페이지 
            for (int sise_page = 1; sise_page <= 3; sise_page++)
            {
                string url = "https://finance.naver.com/sise/sise_market_sum.nhn?&page=" + sise_page;
                var html = web.DownloadString(url);
                document = new HtmlDocument();
                document.LoadHtml(html);

                var sise_tbody = document.DocumentNode.SelectSingleNode("//*[@id=\"contentarea\"]/div[3]/table[1]/tbody");

                var sise_tr = sise_tbody.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)"))
                    .ToList();

                foreach (var i in sise_tr)
                {
                    var codeName = i.ChildNodes[3].FirstChild.InnerHtml;

                    foreach (var check in stockData.Select())
                    {
                        if (check.StockName.Equals(codeName))

                        {
                            var stockCodeFromCodeName = stockData.stockCode(codeName);
                            //종목당 자료페이지
                            for (int page = 1; page <= 50; page++)
                            {
                                string frgn_url = "https://finance.naver.com/item/frgn.nhn?code=" + stockCodeFromCodeName[0] + "&page=" + page;
                                var frgn_html = web.DownloadString(frgn_url);
                                HtmlDocument frgn_document;
                                frgn_document = new HtmlDocument();
                                frgn_document.LoadHtml(frgn_html);    //맥쿼리인스타 상장주식수 위치 다름 , eps 없음... 다음으로...
                                //주식수
                                var frgn_tradeStockHoldings =
                                    frgn_document.DocumentNode.SelectSingleNode("//*[@id=\"tab_con1\"]/div[1]/table/tr[3]");
                                //*[@id="tab_con1"]/div[1]/table/tbody/tr[2]/td
                                var frgn_trade = frgn_tradeStockHoldings.ChildNodes[3].FirstChild.InnerHtml;
                                if (frgn_trade == "N/A")
                                {
                                    frgn_trade = "0";
                                }

                                //per krx
                                var frgn_eps = frgn_document.DocumentNode.SelectSingleNode("//*[@id=\"tab_con1\"]/div[4]/table/tr[1]/td/em[2]").InnerHtml;
                                
                                //코드번호
                                var frgn_code = frgn_document.DocumentNode
                                    .SelectSingleNode("//*[@id=\"middle\"]/div[1]/div[1]/div/span[1]").InnerHtml;

                                var frgn_table = frgn_document.DocumentNode.SelectSingleNode(
                                    "//*[@id=\"content\"]/div[2]/table[1]");

                                var frgn_tbody = frgn_table.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)"))
                                    .ToList();

                                //코드번호로 부터 자료 크롤링
                                foreach (var frgn_i in frgn_tbody)
                                {
                                    //날짜
                                    var date = frgn_i.ChildNodes[1].FirstChild.InnerHtml;
                                    if(date == "&nbsp;") { break;}
                                    DateTime dateTime = DateTime.ParseExact(date, "yyyy.MM.dd", null);
                                    var string_dateTime = dateTime.ToString("yyyy.MM.dd");

                                    //종가
                                    var lastPrice = float.Parse(frgn_i.ChildNodes[3].FirstChild.InnerHtml);

                                    //외국인 보유율
                                    var stockHoldings = frgn_i.ChildNodes[17].FirstChild.InnerHtml;
                                    var search = "%";
                                    var sub_stockHoldings =
                                        double.Parse(stockHoldings.Substring(0, stockHoldings.IndexOf(search)));

                                    var priceDate = price.Date.ToString("yyyy.MM.dd");

                                   
                                    
                                        price.Date = dateTime;
                                        price.Close = lastPrice;
                                        price.StockHolding = sub_stockHoldings;

                                        price.StockId = stockCodeFromCodeName[0];
                                        price.MarketCap = double.Parse(frgn_trade) * lastPrice;
                                        

                                        if (frgn_eps != "N/A")
                                        {
                                            
                                            price.PER = lastPrice / float.Parse(frgn_eps);

                                        }
                                        else
                                        {
                                            price.PER = 0;
                                        }


                                        Console.WriteLine();


                                    var m = priceData.dateCheck(dateTime,stockCodeFromCodeName[0]).Count;
                                    if (m==0)
                                    {
                                        DataRepository.Price.Insert(price);
                                    }
                                    else
                                    {
                                        DataRepository.Price.Update(price);
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sise_market_Data1();
        }

        private void btnGoldenCross_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucGoldenCross.Instance))
            {
                panel1.Controls.Add(ucGoldenCross.Instance);
                panel2.Controls.Add(ucGoldenCrossDis.Instance);
                ucGoldenCrossDis.Instance.Dock = DockStyle.Fill;
                ucGoldenCrossDis.Instance.BringToFront();
                ucGoldenCross.Instance.Dock = DockStyle.Fill;
                ucGoldenCross.Instance.BringToFront();
            }

            else
            {
                ucGoldenCross.Instance.BringToFront();
                ucGoldenCrossDis.Instance.BringToFront();
            }
        }

        private void btnStockHolding_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucStockHolding.Instance))
            {
                panel1.Controls.Add(ucStockHolding.Instance);
                panel2.Controls.Add(ucStockHoldingDis.Instance);
                ucStockHoldingDis.Instance.Dock = DockStyle.Fill;
                ucStockHoldingDis.Instance.BringToFront();
                ucStockHolding.Instance.Dock = DockStyle.Fill;
                ucStockHolding.Instance.BringToFront();
            }

            else
            {
                ucStockHolding.Instance.BringToFront();
                ucStockHoldingDis.Instance.BringToFront();
            }

        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucPer.Instance))
            {
                panel1.Controls.Add(ucPer.Instance);
                panel2.Controls.Add(ucPerDis.Instance);
                ucPer.Instance.Dock = DockStyle.Fill;
                ucPer.Instance.BringToFront();
                ucPerDis.Instance.Dock = DockStyle.Fill;
                ucPerDis.Instance.BringToFront();
            }

            else
            {
                ucPer.Instance.BringToFront();
                ucPerDis.Instance.BringToFront();
            }
            ucPer ucper = new ucPer();
            ucper.ucPer_Data_Price();
            dataGridView1.DataSource = ucper.ucPer_Data();
        }
    }
}
