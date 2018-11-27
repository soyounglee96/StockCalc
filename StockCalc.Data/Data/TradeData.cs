using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class TradeData : EntityData<Trade>
    {
        private DateTime today = Convert.ToDateTime("2018-11-20");

        public List<Trade> CalculateGoldenCross(double baseMoney, int shortMva, int longMva, int stockCount)
        {
            List<DateTime> date = DataRepository.Price.GetDate();
            foreach (var day in date)
            {
                if (!(baseMoney > 0)) continue;
                List<string> marketTops = DataRepository.Price.GetTop(day, stockCount);
                foreach (var marketTop in marketTops)
                {
                    // 골든크로스인지 확인
                    if (!DataRepository.Price.IsGoldenCross(day, marketTop, shortMva, longMva) ||
                        !(baseMoney > 0)) continue;
                    double todayClose = DataRepository.Price.SelectByDateNId(today, marketTop);
                    double buyPrice = DataRepository.Price.SelectByDateNId(day, marketTop);
                    Trade t = new Trade
                    {
                        StrategyId = 1,
                        StockId = marketTop,
                        BuyDate = day,
                        BuyPrice = buyPrice,
                        SellDate = null,
                        SellPrice = null,
                        TradeER = (todayClose - buyPrice) / buyPrice
                    };
                    baseMoney -= DataRepository.Price.SelectByDateNId(day, marketTop);
                    DataRepository.Trade.Insert(t);
                }
            }

            var context = CreateContext();
            var query = from x in context.Trades
                select x;
            return query.ToList();
        }

        // Trade table 날짜들의 목록
        public List<DateTime> GetBuyDate()
        {
            var context = CreateContext();

            var query = (from x in context.Trades
                select x.BuyDate).Distinct();

            return query.ToList();
        }

       
        public List<string> GetStockIDinTrade(DateTime date)
        {

            var context = CreateContext();
            var query = from x in context.Trades
                where x.BuyDate.Equals(date)
                select x.StockId;

            return query.ToList();
        }


        // 현재 가치
        public double GetCurrentValue(DateTime date, double baseMoney)
        {
            var context = CreateContext();
            double closeSum = 0.0;
            double buyPriceSum = (from x in context.Trades
                where x.BuyDate.Equals(date) && x.StrategyId.Equals(1)
                select x.BuyPrice).Sum();

            double NMG = baseMoney - buyPriceSum;
            List<string> buyStockId = GetStockIDinTrade(date); 
            
            foreach (var bsi in buyStockId)
            {
                closeSum += DataRepository.Price.SelectByDateNId(today, bsi);
            }

            double currentValue = NMG + closeSum;
            
            return (currentValue - baseMoney) / baseMoney;
        }

    }

}
