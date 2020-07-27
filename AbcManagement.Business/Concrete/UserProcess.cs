using AbcManagement.Business.Abstract;
using AbcManagement.Business.Util;
using AbcManagement.DataAccess.Abstract;
using AbcManagement.DataAccess.ORMs.EF;
using AbcManagement.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcManagement.Business.Concrete
{
    public class UserProcess : IUserProcess, IDisposable
    {
        private readonly DatabaseContext _context;
        private readonly IDA_Users _daUsers;

        public UserProcess(DatabaseContext context)
        {
            context.Database.EnsureCreated();
            _context = context;
            _daUsers = InjectionManager.GetInstance<IDA_Users>();

        }

        public bool Save(User entity)
        {
            try
            {
                var addItem = _context.Entry(entity);
                addItem.State = EntityState.Added;
                return _context.SaveChanges() == 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(User entity)
        {
            try
            {
                var updateItem = _context.Entry(entity);
                updateItem.State = EntityState.Modified;
                return _context.SaveChanges() == 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(User entity)
        {
            try
            {
                var deleteItem = _context.Entry(entity);
                deleteItem.State = EntityState.Deleted;
                return _context.SaveChanges() == 1;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public User Find(Expression<Func<User, bool>> filter)
        {
            return _context.Users.SingleOrDefault<User>(filter);            
        }

        public List<User> List_Users(Expression<Func<User, bool>> filter)
        {
            List<User> allUsers = filter == null
                     ? _context.Users.ToList()
                     : _context.Users.Where(filter).ToList();
            return allUsers;
        }

        public void Dispose()
        {
        }
    }
}
