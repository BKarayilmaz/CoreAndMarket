using CoreAndMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
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
        public List<T> ListT(string p)
        {
            return c.Set<T>().Include(p).ToList();
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
        public T GetT(int id)
        {
           return c.Set<T>().Find(id);
           
        }
        
    }
}
