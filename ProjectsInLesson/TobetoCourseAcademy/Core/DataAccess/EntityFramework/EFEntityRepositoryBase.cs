using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        protected TContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EFEntityRepositoryBase(TContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            //using (TContext context = new TContext())
            //{
            //var addedEntity = context.Entry(entity);
            //addedEntity.State = EntityState.Added;
            //}

            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            //using (TContext context = new TContext())
            //{
            //    var deletedEntity = context.Entry(entity);
            //    deletedEntity.State = EntityState.Deleted;
            //    context.SaveChanges();
            //}
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            //using (TContext context = new TContext())
            //{
            //    return context.Set<TEntity>().SingleOrDefault(filter);
            //}

            return _dbSet.SingleOrDefault(filter);

        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            //using (TContext context = new TContext())
            //{
            //    return filter == null
            //        ? context.Set<TEntity>().ToList()
            //        : context.Set<TEntity>().Where(filter).ToList();
            //}

            return filter == null
                    ? _dbSet.ToList()
                    : _dbSet.Where(filter).ToList();

        }

        public void Update(TEntity entity)
        {
            //using (TContext context = new TContext())
            //{
            //    var updatedEntity = context.Entry(entity);
            //    updatedEntity.State = EntityState.Modified;
            //    context.SaveChanges();
            //}

            _dbSet.Update(entity);
            _context.SaveChanges();
        }

    }
}
