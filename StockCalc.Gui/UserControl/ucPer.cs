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



        public void ucPer_Data()
        {
            PriceData priceData = new PriceData();
            TradeData tradeData = new TradeData();
            Strategy strategy = new Strategy();
            Stock stock = new Stock();
            Price price = new Price();
            Trade trade = new Trade();

            int count = 0;
            var per_low_num = float.Parse(numericUpDown2.Value.ToString());
            var per_high_num = float.Parse(numericUpDown3.Value.ToString());
            var per_countStock = Int32.Parse(numericUpDown1.Value.ToString());
            DateTime dateTime = DateTime.Now;

            var dateList = priceData.dateCheckList();
            foreach (var time in dateList)
            {
                var perPriceList = priceData.PerRange(per_low_num, per_high_num, time, per_countStock);
                Console.WriteLine();

                foreach (var data in perPriceList)
                {
                    trade.StockId = data.StockId;
                    trade.BuyDate = data.Date;
                    trade.BuyPrice = data.Close;
                    trade.SellDate = null;
                    trade.SellPrice = null;
                    trade.StrategyId = 3;
                    trade.TradeER = 0.0;

                    DataRepository.Trade.Insert(trade);
                }
            }
        }
    }
}
