using AbcManagement.Business.Abstract;
using AbcManagement.DataAccess.ORMs.EF;
using AbcManagement.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AbcManagement.Business.Concrete
{
    public class WorkProcess : IWorkProcess, IDisposable
    {
        private readonly DatabaseContext _context;

        public WorkProcess(DatabaseContext context)
        {
            _context = context;
        }

        public bool Save(Work entity)
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

        public bool Update(Work entity)
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

        public bool Delete(Work entity)
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

        public Work Find(Expression<Func<Work, bool>> filter)
        {
            return _context.Works.SingleOrDefault<Work>(filter);
        }

        public List<Work> List_Works(Expression<Func<Work, bool>> filter)
        {
            List<Work> allWorks = filter == null
                     ? _context.Works.ToList()
                     : _context.Works.Where(filter).ToList();
            return allWorks;
        }

        public void Dispose()
        {
        }
    }
}
