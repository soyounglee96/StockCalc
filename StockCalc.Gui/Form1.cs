using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockCalc.Gui.UserControl;
using HtmlAgilityPack;

namespace StockCalc.Gui
{
    public partial class Form1 : Form
    {
        

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient web = new WebClient();
            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            web.Encoding = Encoding.Default;


            //string url = "https://finance.naver.com/sise/sise_market_sum.nhn?&page=" + 1; <--
            string url = "https://finance.naver.com/item/sise_day.nhn?code=005930";
            var html = web.DownloadString(url);

            document.LoadHtml(html);

            //*[@id="middle"]/div[1]/div[1]/div/span[1]
            //var code = document.DocumentNode.SelectSingleNode("//*[@id=\"middle\"]/div[1]/div[1]/div"); // 주소가 다름
            //var tbody = document.DocumentNode.SelectSingleNode("//*[@id=\"contentarea\"]/div[3]/table[1]/tbody"); <--
            var tbody = document.DocumentNode.SelectSingleNode("/html/body/table[1]"); //두번째 웹사이트

            var tr = tbody.ChildNodes.Where(x => x.GetAttributeValue("onmouseover", "").Equals("mouseOver(this)")).ToList();
            //var tr = tbody.ChildNodes.Where(x => x.Name == "tr").ToList();

            foreach (var i in tr)
            {
                
                var day = i.ChildNodes[3].FirstChild.InnerHtml;
                textBox4.AppendText(day+"\n");
                //textBox4.Text= day;
                //DateTime dateTime = DateTime.ParseExact(day,"yy.MM.dd",null);
                //var count = i.ChildNodes[3].FirstChild.InnerHtml;
            }

        }
    }
}
