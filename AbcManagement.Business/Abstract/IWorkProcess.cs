using AbcManagement.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AbcManagement.Business.Abstract
{
    public interface IWorkProcess
    {
        bool Save(Work entity);
        bool Update(Work entity);
        bool Delete(Work entity);
        Work Find(Expression<Func<Work, bool>> filter);
        List<Work> List_Works(Expression<Func<Work, bool>> filter);
    }
}
