using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EFCourseInstructorDal : ICourseInstructorDal
    {
        public void Add(CourseInstructor entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(CourseInstructor entity)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public CourseInstructor Get(Expression<Func<CourseInstructor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CourseInstructor> GetAll(Expression<Func<CourseInstructor, bool>> filter = null)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                return filter == null 
                    ? context.Set<CourseInstructor>()
                    .Include(x => x.Course)
                    .ThenInclude(x=>x.Category)
                    .Include(x => x.Instructor)
                    .ToList() 
                    : context.Set<CourseInstructor>()
                    .Where(filter)
                    .Include(x => x.Course)
                    .ThenInclude(x => x.Category)
                    .Include(x => x.Instructor)
                    .ToList();
            }
        }

        public void Update(CourseInstructor entity)
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
