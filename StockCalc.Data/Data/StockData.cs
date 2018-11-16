using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class StockData : EntityData<Stock>
    {
        public void SelectById(List<int> Id)
        {
            foreach (var value in Id)
            {
                DataRepository.Stock.Select().Where(x => x.StockId == value);
            }
            
        }
    }
}
