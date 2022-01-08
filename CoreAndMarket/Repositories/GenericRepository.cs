using CoreAndMarket.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndMarket.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        Context c = new Context();
        public List<T> ListT()
        {
            return c.Set<T>().ToList();
        }
        public void AddT(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();
        }
        public void DeleteT(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }
        public void UpdateT(T t)
        {
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
        public void GetT(int id)
        {
            c.Set<T>().Find(id);
            c.SaveChanges();
        }
    }
}
