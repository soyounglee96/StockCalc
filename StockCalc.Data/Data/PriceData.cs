using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
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

        // 날짜들의 목록
        public List<DateTime> GetDate()
        {
            var context = CreateContext();

            var query = (from x in context.Prices
                select x.Date).Distinct();

            return query.ToList();
        }


        // 날짜에 따른 시총순위 10개 가져오기
        public List<string> GetTop(DateTime date, int stockCount)
        {
            var context = CreateContext();
            var query = (from x in context.Prices
                where x.Date.Equals(date)
                orderby x.MarketCap descending
                select x.StockId).Take(stockCount);

            return query.ToList();
        }
    
       
        // 날짜와 종목코드에 따른 종가
        public double SelectByDateNId(DateTime date, string id)
        {
            
            var context = CreateContext();
            double dayClose = (from x in context.Prices
                where  x.Date.Equals(date) && x.StockId.Equals(id)
                select x.Close).First();

            return dayClose;
        }

       

        // 골든크로스인지 확인
        public bool IsGoldenCross(DateTime date, string id, int mva1, int mva2)
        {
            var context = CreateContext();

            var shortMvaCount = context.Prices.Where(x => x.Date <= date && x.StockId.Equals(id))
                .OrderByDescending(x => x.Date) 
                .Select(x => x.Close).Count();
            var yesterdayShortMvaCount = (context.Prices.Where(x => x.Date < date && x.StockId.Equals(id))
                .OrderByDescending(x => x.Date)
                .Select(x => x.Close)).Count();
            var longMvaCount = (context.Prices.Where(x => x.Date <= date && x.StockId.Equals(id))
                .OrderByDescending(x => x.Date)
                .Select(x => x.Close)).Count();


            if (shortMvaCount < mva1 || yesterdayShortMvaCount < mva1 || longMvaCount < mva2) return false;
            var shortMva = (from x in context.Prices
                where x.Date <= date && x.StockId.Equals(id)
                orderby x.Date descending
                select x.Close).Take(mva1).Average();

            var yesterdayShortMva = (from x in context.Prices
                where x.Date < date && x.StockId.Equals(id)
                orderby x.Date descending
                select x.Close).Take(mva1).Average();

            var longMva = (from x in context.Prices
                where x.Date <= date && x.StockId.Equals(id)
                orderby x.Date descending
                select x.Close).Take(mva2).Average();

            return shortMva >= longMva && longMva >= yesterdayShortMva;
        }

    }
}

