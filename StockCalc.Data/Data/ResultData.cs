using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public class ResultData : EntityData<Result>
    {
        /*public List<Result> GetCurrent(double baseMoney)
        {
            List<DateTime> date = DataRepository.Price.GetDate();
            List<DateTime> buyDate = DataRepository.Trade.GetBuyDate();
            foreach (var day in date)
            {
                if (buyDate.Contains(day))
                {
                    Result r = new Result()
                    {
                        StrategyId = 1,
                        TDate = day,
                        BaseMoney = baseMoney,
                        CurrentValue = DataRepository.Trade.GetCurrentValue(day, baseMoney),
                        CurrentER = (DataRepository.Trade.GetCurrentValue(day, baseMoney) - baseMoney) / baseMoney
                    };
                    DataRepository.Result.Insert(r);
                }
                else
                {
                    Result r = new Result()
                    {
                        StrategyId = 1,
                        TDate = day,
                        BaseMoney = baseMoney,
                        CurrentValue = baseMoney,
                        CurrentER = (baseMoney - baseMoney) / baseMoney
                    };
                    DataRepository.Result.Insert(r);

                }
            }
            var context = CreateContext();
            var query = from x in context.Results
                select x;
            return query.ToList();
        }*/

    }
}
