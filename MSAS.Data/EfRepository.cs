using MSAS.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSAS.Data
{
    public class EfRepository<T> : IRepository<T> where T : class
    {
        private IDbContext Context;

        private IDbSet<T> Entities
        {
            get { return this.Context.Set<T>(); }
        }

        public EfRepository(IDbContext context)
        {
            this.Context = context;

        }

        public IQueryable<T> GetAll()
        {
            return Entities.AsQueryable();
        }

        public T GetById(object id)
        {
            return Entities.Find(id);
        }

        public void Insert(T entity)
        {
            Entities.Add(entity);
            this.Context.SaveChanges();
        }

        public void Update(T entity)
        {
            //if (entity == null)
            //throw new ArgumentNullException("entity");

            this.Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Entities.Remove(entity);
            this.Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.Context != null)
                {
                    this.Context.Dispose();
                    this.Context = null;
                }
            }
        }

        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }
    }
}
