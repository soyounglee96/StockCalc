using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockCalc.Gui.UserControl
{
    public partial class ucStockHoldingDis : System.Windows.Forms.UserControl
    {
        public static ucStockHoldingDis _instance;

        public static ucStockHoldingDis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucStockHoldingDis();
                }

                return _instance;
            }
        }
        public ucStockHoldingDis()
        {

            InitializeComponent();
        }
    }
}
