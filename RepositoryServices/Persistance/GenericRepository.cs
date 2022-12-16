using DAL;
using Entities;
using RepositoryServices.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance
{
    public class GenericRepository<T> : IGenericRepository<T> where T : MundialEntity
    {
        public ApplicationDbContext db;
        public DbSet<T> table;

        public GenericRepository(ApplicationDbContext context)
        {
            db = context;
            table = db.Set<T>();                // db.Set<T>(); Σαν να φέρνει μια λίστα από teams, players, coaches
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            db.Entry(obj).State = EntityState.Added;
            /*table.Add(obj);*/                             // that works too
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
        
        public void Delete(object id)
        {
           T existing = table.Find(id);
            table.Remove(existing);     
        }

        public void Save()
        {
            db.SaveChanges();            
        }

        public IEnumerable<T> Find(Expression<Func<T,bool>> predicate)
        {
            return table.Where(predicate);
        }

        public T SingleOrDefault(Expression<Func<T, bool>> predicate)
        {
            return table.SingleOrDefault(predicate);
        }
    }
}
