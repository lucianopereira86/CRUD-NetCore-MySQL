using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using APICRUDCoreRegister.Infra.Data.MSSQL.Context;

namespace APICRUDCoreRegister.Infra.Data.MYSQL.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected DBContext Context;

        private DbSet<T> _entity;

        public BaseRepository(DBContext ctx)
        {
            Context = ctx;
            _entity = Context.Set<T>();
        }

        public virtual IEnumerable<T> All(Expression<Func<T, bool>> where)
        {
            return _entity.Where(where);
        }

        public virtual void Delete(T entity)
        {
            Context.Remove(entity);
            Context.SaveChanges();
        }

        public virtual bool Exist(Expression<Func<T, bool>> where)
        {
            return _entity.Any(where);
        }

        public virtual T Find(object id)
        {
            var e = _entity.Find(id);
            if (e != null)
                Context.Entry(e).State = EntityState.Detached;
            return e;
        }

        public virtual T Save(T entity)
        {
            _entity.Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public virtual void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public virtual void Patch(T entity)
        {
            Context.Attach(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}
