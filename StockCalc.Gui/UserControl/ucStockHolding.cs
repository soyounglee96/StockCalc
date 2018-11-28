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

        // 입력한 값에 다른 tradeData를 채웁니다. 검색 버튼을 눌렀을 때 시작합니다. 
        public void StockHoldingsInsert()
        {

            List<DateTime> Date = new List<DateTime>();
            Date = DataRepository.Price.GetDate();


            foreach (var datetime in Date)
            {
                List<Price> stock = new List<Price>();
                stock = DataRepository.Price.StockHoldings(int.Parse(numericUpDown2.Text),
                    float.Parse(numericUpDown1.Text), datetime);

                foreach (var id in stock)
                {
                    Trade trade = new Trade();
                    trade.StockId = id.StockId;
                    trade.BuyDate = datetime;
                    trade.BuyPrice = id.Close;
                    trade.StrategyId = 2;
                    trade.TradeER = 0;
                    DataRepository.Trade.Insert(trade);
                }
            }


        }



        // List에 TradeData 담기
        public List<Trade> GetTrades()
        {
            List<Trade> trades = new List<Trade>();
            trades = DataRepository.Trade.GetStratagy2();

            return trades;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ucStockHolding stockHolding = new ucStockHolding();



        }
    }
}
