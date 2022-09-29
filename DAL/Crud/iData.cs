using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL.Crud
{
    interface iData<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        IEnumerable<T> GetAllData();
        IEnumerable<T> GetDataBy(Expression<Func<T, bool>> p);
        IEnumerable<T> GetMaxID(Expression<Func<T, bool>> p);
        bool Update(T entity);
    }
}