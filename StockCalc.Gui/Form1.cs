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
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            //sise_market_Data();
        }

        private void btnGoldenCross_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucGoldenCross.Instance))
            {
                panel1.Controls.Add(ucGoldenCross.Instance);
//                panel2.Controls.Add(ucGoldenCrossDis.Instance);
  //              ucGoldenCrossDis.Instance.Dock = DockStyle.Fill;
    //            ucGoldenCrossDis.Instance.BringToFront();
                ucGoldenCross.Instance.Dock = DockStyle.Fill;
                ucGoldenCross.Instance.BringToFront();
            }

            else
            {
                ucGoldenCross.Instance.BringToFront();
      //          ucGoldenCrossDis.Instance.BringToFront();
            }

            lbDis.Text = @"시가총액 순위대로 10개의 종목을 GoldenCross가 발생했을 때 1주씩 매입";


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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(ucGoldenCross.Instance))
            {
                ucGoldenCross ucgoldenCross = new ucGoldenCross();
                dataGridView1.DataSource = ucgoldenCross.ucGoldenCross_Data();

            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
