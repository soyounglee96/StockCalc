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
    public partial class ucPer : System.Windows.Forms.UserControl
    {
        public static ucPer _instance;

        public static ucPer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPer();
                }

                return _instance;
            }
        }

        public ucPer()
        {
            InitializeComponent();
        }
    }
}
