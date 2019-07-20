using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories
{

    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> All(Expression<Func<T, bool>> where);

        T Save(T entity);

        void Delete(T entity);

        void Update(T entity);

        void Patch(T entity);

        T Find(object id);

        bool Exist(Expression<Func<T, bool>> where);
    }
}
