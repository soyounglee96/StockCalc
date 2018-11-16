using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class DataRepository
    {
        public static PriceData Price { get; set; } = new PriceData();
        public static ResultData Result { get; set; } = new ResultData();
        public static StockData Stock { get; set; } = new StockData();
        public static StrategyData Strategy { get;} = new StrategyData();
        public static TradeData Trade { get; } = new TradeData();


    }
}
