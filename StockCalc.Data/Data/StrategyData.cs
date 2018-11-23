using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class StrategyData : EntityData<Strategy>
    {
        public List<Strategy> searchStrategy(string name)
        {
            var context = CreateContext();
            var query = from x in context.Strategies
                where x.StrategyName.Equals(name)
                select x;
            return query.ToList();
        }
    }
}
