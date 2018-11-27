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
    public partial class StockCalculator : Form
    {
        public static double baseMoney;
        public StockCalculator()
        {
            InitializeComponent();
        }

        private void StockCalculator_Load(object sender, EventArgs e)
        {
           baseMoney = double.Parse(txtBaseMoney.Text);
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
                ucGoldenCross.Instance.Dock = DockStyle.Fill;
                ucGoldenCross.Instance.BringToFront();
            }
            else
            {
                ucGoldenCross.Instance.BringToFront();
            }
            lbDis.Text = @"시가총액 순위대로 10개의 종목을 GoldenCross가 발생했을 때 1주씩 매입";


        }

        private void btnStockHolding_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucStockHolding.Instance))
            {
                panel1.Controls.Add(ucStockHolding.Instance);
                ucStockHolding.Instance.Dock = DockStyle.Fill;
                ucStockHolding.Instance.BringToFront();
            }

            else
            {
                ucStockHolding.Instance.BringToFront();
            }
            lbDis.Text = @"외국인의 보유량이 5% 이상인 종목 중 상위 10개를 1주씩 매입";

        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ucPer.Instance))
            {
                panel1.Controls.Add(ucPer.Instance);
                ucPer.Instance.Dock = DockStyle.Fill;
                ucPer.Instance.BringToFront();
            }

            else
            {
                ucPer.Instance.BringToFront();
            }
            lbDis.Text = @"PER의 범위가 2 - 10 % 인 종목 중 하위 10개를 1주씩 매입";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (panel1.Controls.Contains(ucGoldenCross.Instance))
            {
                ucGoldenCross ucgoldenCross = new ucGoldenCross();
                dataGridView1.DataSource = ucgoldenCross.ucGoldenCross_Data(baseMoney);

            }
            else if(panel1.Controls.Contains(ucStockHolding.Instance))
            {
                

            }
            else
            {
                ucPer ucper = new ucPer();
                ucper.ucPer_Data_Price();
                dataGridView1.DataSource = ucper.ucPer_Data();
            }

        }

       
    }
}
