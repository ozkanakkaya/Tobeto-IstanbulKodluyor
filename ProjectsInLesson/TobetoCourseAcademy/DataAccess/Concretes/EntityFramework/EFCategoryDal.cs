using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EntityFramework
{
    public class EFCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return context.Set<Category>().SingleOrDefault(filter);
            }
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return filter == null
                        ? context.Set<Category>().ToList()
                        : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
