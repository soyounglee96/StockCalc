using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockCalc.Data.Data;

namespace StockCalc.Data.Data
{
    public class PriceData : EntityData<Price>
    {

        public static List<String> GetMemberId()
        {
            var context = DBContext.Create();

            var query = from x in context.Prices
                select x.StockId;

            return query.ToList();
        }

        public static DataTable GetPriceList()
        {
            DataTable table = new DataTable();

            using (StockCalcEntities1 context = DBContext.Create())
            {
                DataRepository.Price.Get();

                return table;

            }

        }

        public List<string> StockHoldings(int selectN, float holdings)
        {
            var context = DBContext.Create();

            var query = (from x in context.Prices
                where x.StockHolding >= holdings
                orderby x.StockHolding descending
                select x.StockId).Take(selectN);

            return query.ToList();
        }

    }
}
