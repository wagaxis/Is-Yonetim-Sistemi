using AbcManagement.DataAccess.ORMs.EF;
using AbcManagement.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AbcManagement.Business.Concrete
{
    public class WorkUsersProcess : IDisposable
    {
        private readonly DatabaseContext _context;

        public WorkUsersProcess(DatabaseContext context)
        {
            _context = context;
        }

        public bool Save(WorkUser entity)
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

        public bool Update(WorkUser entity)
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

        public bool Delete(WorkUser entity)
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

        public WorkUser Find(Expression<Func<WorkUser, bool>> filter)
        {
            return _context.WorkUsers.SingleOrDefault<WorkUser>();
        }

        public List<WorkUser> List_WorkUsers(Expression<Func<WorkUser, bool>> filter)
        {
            List<WorkUser> allUsers = filter == null
                     ? _context.WorkUsers.ToList()
                     : _context.WorkUsers.Where(filter).ToList();
            return allUsers;
        }

        public void Dispose()
        {
        }
    }
}
