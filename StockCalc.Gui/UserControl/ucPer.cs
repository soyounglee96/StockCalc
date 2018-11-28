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
        List<Price> perPriceList;

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

      
        //public List<Price> ucPer_Data()
        //{
        //    //PriceData priceData = new PriceData();
        //    //var per_low_num = float.Parse(numericUpDown2.Value.ToString());
        //    //var per_high_num = float.Parse(numericUpDown3.Value.ToString());
        //    //var perPriceList = priceData.PerRange(per_low_num, per_high_num);
        //    //return perPriceList;
        //}

        public List<Price> ucPer_Data_Price()
        {
            PriceData priceData = new PriceData();
            Price price = new Price();
            Trade trade = new Trade();
            var per_low_num = float.Parse(numericUpDown2.Value.ToString());
            var per_high_num = float.Parse(numericUpDown3.Value.ToString());
            var per_stockCount = int.Parse(numericUpDown1.Value.ToString());
            

            foreach (var dateList in priceData.GetDate())
            {
                
                perPriceList = priceData.PerRange(dateList, per_low_num, per_high_num, per_stockCount);

                foreach (var test in perPriceList)
                {
                    trade.BuyDate = test.Date;
                    trade.BuyPrice = test.Close;
                    trade.SellDate = null;
                    trade.SellPrice = null;
                    trade.StockId = test.StockId;
                    trade.StrategyId = 3;
                    trade.TradeER = 0;

                    //if (test.Date.AddDays(1) == null)
                    //{
                    //    trade.TradeER =0;
                    //}
                    //trade.TradeER = (TradeERPrice(test.Date.AddDays(1), test.Close) - TradeERPrice(test.Date , test.Close))/ TradeERPrice(test.Date, test.Close);

                    DataRepository.Trade.Insert(trade);
                }
            }
            return perPriceList;
        }

        //public double TradeERPrice(DateTime date , double price)
        //{

            
        //}
    }
}
