using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class PriceData : EntityData<Price>
    {
        private List<Price> PerRange(float lowPer, float highPer)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.PER >= lowPer && x.PER <= highPer
                select x;
            return query.ToList();
        }

        private List<Price> StockHolding(float holdings)
        {
            var context = CreateContext();
            var query = from x in context.Prices
                where x.StockHolding >= holdings
                select x;
            return query.ToList();
        }

    }
}
