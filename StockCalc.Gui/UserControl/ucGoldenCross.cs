﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockCalc.Data;
using StockCalc.Data.Data;

namespace StockCalc.Gui.UserControl
{
    public partial class ucGoldenCross : System.Windows.Forms.UserControl
    {
        //private string itemSelected;
        public static ucGoldenCross _instance;
        public static ucGoldenCross Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucGoldenCross();
                }

                return _instance;
            }
        }
        public ucGoldenCross()
        {
            InitializeComponent();
        }

        public List<Trade> ucGoldenCross_Data(double baseMoney)
        {
            int shortMva = int.Parse(cbShortMVA.Text);
            int longMva = int.Parse(cbLongMAV.Text);
            int stockCount = int.Parse(numericUpDown.Value.ToString());
            var goldenCrossTradeList = DataRepository.Trade.CalculateGoldenCross(baseMoney, shortMva, longMva, stockCount);
            return goldenCrossTradeList;

        }

        /*private void cbShortMVA_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemSelected = cbShortMVA.SelectedItem as string;
            
        }

        private void cbLongMVA_SelectedIndexChanged(object sender, EventArgs e)
        {
           itemSelected = cbLongMAV.SelectedItem as string;
          
        }*/
    }
}
