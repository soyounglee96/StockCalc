using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class StocksData : EntityData<Stock>
    {
        public List<string> stockCode(string name)
        {
            var context = CreateContext();
            var query = from x in context.Stocks
                where x.StockName.Equals(name)
                select x.Stockid;

            return query.ToList();
        }
    }
}
