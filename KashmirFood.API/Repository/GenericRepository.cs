using KashmirFood.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace KashmirFood.API.Repository
{
   
        public abstract class GenericRepository<TC, T> : IRepository<T>
            where T : class
            where TC : KashmirFoodContext, new()
        {
            private TC _entities = new TC();

            protected TC Context
            {
                get { return _entities; }
                set { _entities = value; }
            }


            public virtual IQueryable<T> GetAll()
            {
                IQueryable<T> query = _entities.Set<T>();
                return query;
            }

            public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
            {
                var query = _entities.Set<T>().Where(predicate);
                return query;
            }

            public virtual void Add(T entity)
            {
                _entities.Set<T>().Add(entity);
            }

            public virtual void Delete(T entity)
            {
                _entities.Set<T>().Remove(entity);
            }

            public virtual void Edit(T entity)
            {
                _entities.Entry(entity).State = EntityState.Modified;
            }

            public virtual void Save()
            {
                _entities.SaveChanges();
            }
            private bool disposed = false;
            protected virtual void Dispose(bool disposing)
            {

                if (!this.disposed)
                    if (disposing)
                        _entities.Dispose();

                this.disposed = true;
            }

            public void Dispose()
            {

                Dispose(true);
                GC.SuppressFinalize(this);
            }
        }
    
}