﻿using System;
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

                priceDataBindingSource.DataSource = PriceData.GetPriceList();
                
            }

            else
            {
                ucPer.Instance.BringToFront();
                ucPerDis.Instance.BringToFront();
            }



        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void stockBindingSource_CurrentChanged(object sender, EventArgs e)
        {

      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void txtEarning_TextChanged(object sender, EventArgs e)
        {
       
        }

        public void OnResultclicked(int strategyID)
        {
            Result result = new Result();
            result.CurrentER = Convert.ToDouble(txtEarning.Text);
            result.CurrentValue = Convert.ToDouble(txtValue.Text);
            result.TDate = DateTime.Today;
            result.StrategyId = strategyID;
            DataRepository.Result.Insert(result);
        }
    }
}
