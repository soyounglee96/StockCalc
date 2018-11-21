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
    public partial class ucPerDis : System.Windows.Forms.UserControl
    {
        public static ucPerDis _instance;

        public static ucPerDis Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPerDis();
                }

                return _instance;
            }
        }
        public ucPerDis()
        {
            InitializeComponent();
        }
    }
}
