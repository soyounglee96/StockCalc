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
    public partial class ucStockHolding : System.Windows.Forms.UserControl
    {
        public static ucStockHolding _instance;

        public static ucStockHolding Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucStockHolding();
                }
                return _instance;
            }
        }
        
        public ucStockHolding()
        {
            InitializeComponent();
        }

        //public List<>
    }
}
