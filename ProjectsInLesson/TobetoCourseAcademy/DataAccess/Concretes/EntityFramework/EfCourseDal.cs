using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Course entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return filter == null
                     ? context.Set<Course>()
                    .Include(x => x.Category)
                    .Include(x => x.GetCourseInstructors).ThenInclude(x=>x.Instructor)
                    .ToList()
                    : context.Set<Course>()
                    .Where(filter)
                    .Include(x => x.Category)
                    .Include(x => x.GetCourseInstructors).ThenInclude(x => x.Instructor)
                    .ToList();
            }
        }

        public void Update(Course entity)
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
