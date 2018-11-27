using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class TradeData : EntityData<Trade>
    {
        public  List<Trade> CalculateGoldenCross(double baseMoney, int shortMva, int longMva, int stockCount)
        {    
           List<DateTime> date = DataRepository.Price.GetDate();
            foreach (var day in date)
            {
                List<string> marketTops = DataRepository.Price.GetTop(day, stockCount);
                for(int i=0; i < marketTops.Count; i++)
                {
                    // 골든크로스인지 확인
                    if (!DataRepository.Price.IsGoldenCross(day, marketTops[i], shortMva, longMva)) continue;

                    // 자본금이 있는지 확인
                    if(baseMoney > 0)
                    {
                        Trade t = new Trade
                        {
                            StrategyId = 1,
                            StockId = marketTops[i],
                            BuyDate = day,
                            BuyPrice = DataRepository.Price.SelectByDateNId(day, marketTops[i]),
                            SellDate = null,
                            SellPrice = null,
                            TradeER = 0.0
                        };
                        DataRepository.Trade.Insert(t);
                        baseMoney -= DataRepository.Price.SelectByDateNId(day, marketTops[i]);
                    }
                    break;                    
                }
            }
            var context = CreateContext();
            var query = from x in context.Trades
                select x;
            return query.ToList();
        }
    }
}

