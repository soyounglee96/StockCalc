using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data
{
    public class DBContext
    {
        private const string ConnectionString =
            "metadata=res://*/StockCalcEntity.csdl|res://*/StockCalcEntity.ssdl|res://*/StockCalcEntity.msl;provider=System.Data.SqlClient;provider connection string=\"data source=402-30;initial catalog=StockCalc;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework\"";


        public static StockCalcEntities1 Create()
        {
            StockCalcEntities1 context = new StockCalcEntities1(ConnectionString);

        
            return context;
        }
    }
}
