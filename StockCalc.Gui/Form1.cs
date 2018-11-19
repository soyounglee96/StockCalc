using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockCalc.Gui.UserControl;
using StockCalc.Data;
using StockCalc.Data.Data;

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

            List<Stock> result = new List<Stock>();
            result = DataRepository.Stock.Select(x => x);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'stockCalcDataSet.Stock' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            /*
            this.stockTableAdapter.Fill(result);
            //this.stockCalcDataSet.Stock*/
        }

        private void stockBindingSource_CurrentChanged(object sender, EventArgs e)
        {


        }

    
    }
}
