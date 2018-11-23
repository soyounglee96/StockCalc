using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class TradeData : EntityData<Trade>
    {
        public List<Trade> dateCheck(DateTime date)
        {
            var context = CreateContext();
            var query = from x in context.Trades
                where x.BuyDate.Equals(date) 
                select x;
            return query.ToList();
        }
        public List<Trade> tradeCode(string code)
        {
            var context = CreateContext();
            var query = from x in context.Trades
                where x.StockId.Equals(code)
                select x;
            return query.ToList();
        }
    }
}

