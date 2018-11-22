using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using StockCalc.Data;
using StockCalc.Data.Data;

namespace StockCalc.Cui
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> marketTop10 = new List<string>();
            DateTime dResult = DateTime.ParseExact("2018-11-20", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
//            DateTime date = DateTime.ParseExact(day, "yyyy.MM.dd", null);
            int movingAverageDay = 20;
            // 시총 순위 10개를 가져옴
            marketTop10 = DataRepository.Price.GetTop10(dResult);

            // 이평선의 값을 구함
           // double movingAverage = DataRepository.Price.GetMVA(dResult, movingAverageDay, marketTop10[0]);

            // 골든크로스인지 아닌지 비교
            //if(DataRepository.Price.SelectById(dResult, marketTop10[0]) >= movingAverage)
            //Console.WriteLine(movingAverage);
        }
    }
}
