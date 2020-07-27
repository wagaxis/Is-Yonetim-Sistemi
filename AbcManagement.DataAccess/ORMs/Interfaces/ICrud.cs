using AbcManagement.DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AbcManagement.DataAccess.ORMs.Interfaces
{
    public interface ICrud<T> where T : class
    {
        bool Save(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        List<T> List(Expression<Func<T, bool>> filter);

        T Find(Expression<Func<T, bool>> filter);
    }
}
