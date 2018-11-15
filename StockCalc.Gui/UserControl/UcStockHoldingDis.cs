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
    public partial class UcStockHoldingDis : System.Windows.Forms.UserControl
    {
        public static UcStockHoldingDis _instance;

        public static UcStockHoldingDis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UcStockHoldingDis();
                }

                return _instance;
            }
        }
        public UcStockHoldingDis()
        {
        
        InitializeComponent();
        }
    }
}
