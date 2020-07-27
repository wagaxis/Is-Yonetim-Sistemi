using AbcManagement.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AbcManagement.Business.Abstract
{
    public interface IUserProcess
    {
        bool Save(User entity);
        bool Update(User entity);
        bool Delete(User entity);
        User Find(Expression<Func<User, bool>> filter);
        List<User> List_Users(Expression<Func<User, bool>> filter);
    }
}
