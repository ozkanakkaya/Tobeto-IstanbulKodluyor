using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EFEntityRepositoryBase<Course, TobetoCourseAcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from co in context.Courses
                             join c in context.Categories
                             on co.CategoryId equals c.Id
                             join ci in context.CourseInstructors
                             on co.Id equals ci.CourseId
                             select new CourseDetailDto
                             {
                                 CourseId = co.Id,
                                 CourseName = co.Name,
                                 InstructorName = ci.Instructor.FirstName +" "+ ci.Instructor.LastName,
                                 CategoryName = c.Name,
                                 CoursePrice = co.Price,
                                 CourseImage = co.ImageUrl,
                                 CourseDescription = co.Description
                             };
                return result.ToList();
            }
        }
    }
}
