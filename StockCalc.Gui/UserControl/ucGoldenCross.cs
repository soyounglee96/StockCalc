using System;
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

        public List<Trade> ucGoldenCross_Data()
        {
            int shortMva = int.Parse(cbShortMVA.Text);
            int longMva = int.Parse(cbLongMAV.Text);
            int stockCount = int.Parse(numericUpDown.Value.ToString());
            var goldenCrossTradeList = DataRepository.Trade.CalculateGoldenCross(shortMva, longMva, stockCount);
            return goldenCrossTradeList;
        }
    }
}
