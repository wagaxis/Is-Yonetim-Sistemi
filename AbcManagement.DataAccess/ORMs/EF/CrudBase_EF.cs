using AbcManagement.DataAccess.ORMs.Interfaces;
using AbcManagement.DataAccess.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace AbcManagement.DataAccess.ORMs.EF
{
    public class CrudBase_EF<TEntity, TContext> : ICrud<TEntity>
          where TEntity : class
          where TContext : DbContext, new()
    {
        public bool Save(TEntity entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var addItem = context.Entry(entity);
                    addItem.State = EntityState.Added;
                    return context.SaveChanges() == 1;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(TEntity entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var updateItem = context.Entry(entity);
                    updateItem.State = EntityState.Modified;
                    return context.SaveChanges() == 1;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(TEntity entity)
        {
            try
            {
                using (var context = new TContext())
                {
                    var deleteItem = context.Entry(entity);
                    deleteItem.State = EntityState.Deleted;
                    return context.SaveChanges() == 1;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public TEntity Find(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault<TEntity>();
            }
        }

        public List<TEntity> List(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

    }
}
