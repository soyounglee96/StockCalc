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

      
        public List<Price> ucPer_Data()
        {
            PriceData priceData = new PriceData();
            var per_low_num = float.Parse(numericUpDown2.Value.ToString());
            var per_high_num = float.Parse(numericUpDown3.Value.ToString());
            var perPriceList = priceData.PerRange(per_low_num, per_high_num);
            return perPriceList;
        }

        public void ucPer_Data_Price()
        {
            PriceData priceData = new PriceData();
            Price price = new Price();
            var per_low_num = float.Parse(numericUpDown2.Value.ToString());
            var per_high_num = float.Parse(numericUpDown3.Value.ToString());
            var perPriceList = priceData.PerRange(per_low_num, per_high_num);
            List<Price> PricePerList = new List<Price>();
            var sumPerLastPrice = 0.0;
            DateTime sampleDate = DateTime.Now;
            foreach (var ucPerData in perPriceList)
            {
                
                if (sampleDate != ucPerData.Date)
                {
                    sampleDate = ucPerData.Date;
                    
                    //sumPerLastPriceList.Add(sumPerLastPrice);
                }
                //sumPerLastPrice += ucPerData.Close;
                
                Console.WriteLine(sumPerLastPrice);
            }

            Console.WriteLine();
        }

    }
}
