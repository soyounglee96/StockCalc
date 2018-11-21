using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class DataRepository
    {
        private static PriceData _price;

        public static PriceData Price
        {
            get
            {
                if (_price == null)
                    _price = new PriceData();

                return _price;
            }
        }

        private static ResultData _result;

        public static ResultData Result
        {
            get
            {
                if (_result == null)
                    _result = new ResultData();

                return _result;
            }
        }

        private static StockData _stock;

        public static StockData Stock
        {
            get
            {
                if (_stock == null)
                    _stock = new StockData();

                return _stock;
            }
        }

        private static StrategyData _strategy;

        public static StrategyData Strategy
        {
            get
            {
                if (_strategy == null)
                    _strategy = new StrategyData();

                return _strategy;
            }
        }

        private static TradeData _trade;

        public static TradeData Trade
        {
            get
            {
                if (_trade == null)
                    _trade = new TradeData();

                return _trade;
            }
        }
    }
}
