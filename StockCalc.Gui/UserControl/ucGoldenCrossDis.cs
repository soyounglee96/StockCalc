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
    public partial class ucGoldenCrossDis : System.Windows.Forms.UserControl
    {
        public static ucGoldenCrossDis _instance;

        public static ucGoldenCrossDis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucGoldenCrossDis();
                }

                return _instance;
            }
        }
        public ucGoldenCrossDis()
        {
            InitializeComponent();
        }
    }
}
