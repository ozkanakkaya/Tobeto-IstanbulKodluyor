using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class EfInstructorDal : IInstructorDal
    {
        public void Add(Instructor entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Instructor entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Instructor Get(Expression<Func<Instructor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll(Expression<Func<Instructor, bool>> filter = null)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return filter == null ? context.Set<Instructor>().ToList() : context.Set<Instructor>().Where(filter).ToList();
            }
        }

        public void Update(Instructor entity)
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
