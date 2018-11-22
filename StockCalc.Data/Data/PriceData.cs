using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class PriceData : EntityData<Price>
    {
        public List<Price> PerRange(float lowPer, float highPer)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.PER >= lowPer && x.PER <= highPer
                      orderby x.Date 
                select x;
            return query.ToList();
        }
        public List<Price> PerBest(List<Price> list)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                        orderby x.PER
                        select x;
            return query.ToList();
        }

        public List<Price> StockHolding(float holdings)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.StockHolding >= holdings
                select x;
            return query.ToList();
        }

        public List<Price> DateCheck(DateTime date, string id)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.Date.Equals(date)&&x.StockId.Equals(id)
                select x;
            return query.ToList();
        }

        public List<Price> DateCheckOnly(DateTime date)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.Date.Equals(date)
                select x;
            return query.ToList();
        }

        public List<string> GetTop10(DateTime date)
        {
            var context = CreateContext();
            var query = (from x in context.Prices
                where x.Date.Equals(date)
                orderby x.MarketCap descending
                select x.StockId).Take(10);

            return query.ToList();
        }

        public List<Price> SelectById(string id)
        {
            
            var context = CreateContext();
            var query = from x in context.Prices
                where  x.StockId.Equals(id)
                select x;

            return query.ToList();
        }

        /*public bool GetMVA(DateTime date, int period, string id)
        {
            var context = CreateContext();

            // 이평선 구하기
            /*double mva = (from x in context.Prices
                where x.Date < date && x.StockId.Equals(id)
                orderby x.Date descending
                select x.Close).Take(period).Average();

            double dayClose = (from x in context.Prices
                where x.Date.Equals(date) && x.StockId.Equals(id)
                select x.Close).Sum();

            if(dayClose >= mva && )
           // return mva;
        }
        */
    }
}
