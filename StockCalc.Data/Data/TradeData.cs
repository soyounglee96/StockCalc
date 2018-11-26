using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class TradeData : EntityData<Trade>
    {
        public  List<Trade> CalculateGoldenCross(int shortMva, int longMva, int stockCount)
        {           
            List<DateTime> date = DataRepository.Price.GetDate();
            foreach (var day in date)
            {
                List<string> marketTops = DataRepository.Price.GetTop(day, stockCount);
                foreach (var marketTop in marketTops)
                {
                    if (!DataRepository.Price.IsGoldenCross(day, marketTop, shortMva, longMva)) continue;
                    Trade t = new Trade
                    {
                        StrategyId = 1,
                        StockId = marketTop,
                        BuyDate = day,
                        BuyPrice = DataRepository.Price.SelectByDateNId(day, marketTop),
                        SellDate = null,
                        SellPrice = null,
                        TradeER = 0.0
                    };
                    DataRepository.Trade.Insert(t);
                }
            }

            var context = CreateContext();
            var query = from x in context.Trades
                select x;
            return query.ToList();
        }
    }
}

