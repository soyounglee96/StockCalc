using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockCalc.Gui.UserControl;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace StockCalc.Gui
{
    public partial class Form1 : Form
    {
        WebClient web = new WebClient();
        HtmlDocument document = new HtmlDocument();


        public Form1()
        {
            InitializeComponent();
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
                panel2.Controls.Add(UcStockHoldingDis.Instance);
                UcStockHoldingDis.Instance.Dock = DockStyle.Fill;
                UcStockHoldingDis.Instance.BringToFront();
                ucStockHolding.Instance.Dock = DockStyle.Fill;
                ucStockHolding.Instance.BringToFront();
            }

            else
            {
                ucStockHolding.Instance.BringToFront();
                UcStockHoldingDis.Instance.BringToFront();
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

            //sise_market_Data();
            //coinfo_Data();

        }
        //삼성전자 코드번호 따오는
        private void coinfo_Data()
        {
            textBox4.Clear();
            

                web.Encoding = Encoding.Default;

                string url = "https://finance.naver.com/item/coinfo.nhn?code=005930" ;
                var html = web.DownloadString(url);
            //*[@id="middle"]/div[1]/div[1]/div
            document.LoadHtml(html);
                var tbody = document.DocumentNode.SelectSingleNode(
                    "//*[@id=\"middle\"]/div[1]/div[1]/div");

            var tr = tbody.ChildNodes[1].FirstChild;

            textBox4.Text = tr.InnerText;


        }

        private void sise_market_Data()
        {
            textBox4.Clear();
            for (int j = 1; j <= 2; j++)
            {

                web.Encoding = Encoding.Default;

                string url = "https://finance.naver.com/sise/sise_market_sum.nhn?&page=" + j;
                var html = web.DownloadString(url);

                document.LoadHtml(html);
                var tbody = document.DocumentNode.SelectSingleNode(
                    "//*[@id=\"contentarea\"]/div[3]/table[1]/tbody"); 

                var tr = tbody.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)"))
                    .ToList();

                foreach (var i in tr)
                {
                    var Per = i.ChildNodes[21].FirstChild.InnerHtml;

                    if (Per == "N/A"){ Per = "0"; }

                    textBox4.AppendText(Per + "\n");

                    var MarketCap = i.ChildNodes[13].FirstChild.InnerHtml;
                    textBox4.AppendText(MarketCap + "\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            web.Encoding = Encoding.Default;


            //string url = "https://finance.naver.com/sise/sise_market_sum.nhn?&page=" + 1; <--
            string url = "https://finance.naver.com/item/sise_day.nhn?code=005930";
            var html = web.DownloadString(url);

            document.LoadHtml(html);

            //*[@id="middle"]/div[1]/div[1]/div/span[1]
            //var code = document.DocumentNode.SelectSingleNode("//*[@id=\"middle\"]/div[1]/div[1]/div"); // 주소가 다름
            //var tbody = document.DocumentNode.SelectSingleNode("//*[@id=\"contentarea\"]/div[3]/table[1]/tbody"); <--
            var tbody = document.DocumentNode.SelectSingleNode("/html/body/table[1]"); //두번째 웹사이트

            var tr = tbody.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)"))
                .ToList();
            //var tr = tbody.ChildNodes.Where(x => x.Name == "tr").ToList();

            foreach (var i in tr)
            {
                var day = i.ChildNodes[3].FirstChild.InnerHtml;
                textBox4.AppendText(day + "\n");
                //textBox4.Text= day;
                //DateTime dateTime = DateTime.ParseExact(day,"yy.MM.dd",null);
                //var count = i.ChildNodes[3].FirstChild.InnerHtml;
            }

        }
    }
}
