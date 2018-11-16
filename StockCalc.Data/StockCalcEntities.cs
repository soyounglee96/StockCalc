using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data
{
    public partial class StockCalcEntities
    {
        public StockCalcEntities(string connectionString) : base(connectionString) { }
    }
}
