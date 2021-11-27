using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.EntityFrameworkBase
{
    // : IMPLEMENTE MİRAS INHERITANCE
    public class EntityRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        //Ekleme
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var added = context.Entry(entity);
                added.State = EntityState.Added;
                context.SaveChanges(); // Veritabanına kaydeder.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deleted = context.Entry(entity);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault();
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //if (filter == null)
                //{
                //    return context.Set<TEntity>().ToList();
                //}
                //else
                //{
                //    return context.Set<TEntity>().Where(filter).ToList();
                //}

                return filter == null ? //if
                    context.Set<TEntity>().ToList() : //else
                    context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var upd = context.Entry(entity);
                upd.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
