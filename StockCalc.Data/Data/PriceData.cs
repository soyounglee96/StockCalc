﻿using System;
using System.Collections.Generic;
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

        public List<Price> dateCheck(DateTime date, string id)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.Date.Equals(date)&&x.StockId.Equals(id)
                select x;
            return query.ToList();
        }
        
    }
}
