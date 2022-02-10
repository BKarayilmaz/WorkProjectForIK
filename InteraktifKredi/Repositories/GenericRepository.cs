using InteraktifKredi.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace InteraktifKredi.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context c = new Context();
        public List<T> ListData()
        {
            return c.Set<T>().ToList();
        }
        public List<T> ListData(string p)
        {
            return c.Set<T>().Include(p).ToList();
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
        public void AddData(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();
        }
        public void DeleteData(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }
        public void UpdateData(T t)
        {
            c.Set<T>().Update(t);
            c.SaveChanges();
        }
        public T GetData(int id)
        {
            return c.Set<T>().Find(id);

        }
    }
}
