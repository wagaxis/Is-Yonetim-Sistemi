using AbcManagement.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AbcManagement.Business.Abstract
{
    public interface IWorkUsersProcess
    {
        bool Save(WorkUser entity);
        bool Update(WorkUser entity);
        bool Delete(WorkUser entity);
        WorkUser Find(Expression<Func<WorkUser, bool>> filter);
        List<WorkUser> List_WorkUsers(Expression<Func<WorkUser, bool>> filter);
    }
}
