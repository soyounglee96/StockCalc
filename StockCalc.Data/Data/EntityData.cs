using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockCalc.Data.Data
{
    public abstract class EntityData<T> where T : class
    {

        public static StockCalcEntities CreateContext()
        {

            var context = new StockCalcEntities();

            return context;
        }

        public List<T> Select()
        {
            return CreateContext().Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

        // 복수개의 데이터를 DELETE, UPDATE
        public void DeleteMany(List<T> entities)
        {
            var context = CreateContext();
            context.Entry(entities).State = EntityState.Deleted;
            context.SaveChanges();
        }

        public void UpdateMany(List<T> entities)
        {
            var context = CreateContext();
            context.Entry(entities).State = EntityState.Modified;
            context.SaveChanges();
        }

        //SelectBY



    }
}
