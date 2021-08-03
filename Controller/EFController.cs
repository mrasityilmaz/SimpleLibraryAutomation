using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    public class EFController<T> : IController<T> where T:class
    {
       
        private readonly DbSet<T> _dbSet;
        MyContext Context;
       
        public EFController()
        {
            Context = new MyContext();
          
            _dbSet = Context.Set<T>();
        }

        public void Add(T Entity)
        {
            _dbSet.Add(Entity);
            Context.SaveChanges();
        }

        public void Delete(int ID)
        {

            _dbSet.Remove(_dbSet.Find(ID));
            Context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int ID)
        {
            return _dbSet.Find(ID);
        }

        public void Update(T Entity)
        {
            _dbSet.Attach(Entity);
            Context.Entry(Entity).State = EntityState.Modified;
            Context.SaveChanges();
        }


    }
}
