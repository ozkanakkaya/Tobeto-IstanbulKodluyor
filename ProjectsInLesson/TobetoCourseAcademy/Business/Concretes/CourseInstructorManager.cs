using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseInstructorManager : ICourseInstructorService
    {
        ICourseInstructorDal _courseInstructorDal;

        public CourseInstructorManager(ICourseInstructorDal courseInstructorDal)
        {
            _courseInstructorDal = courseInstructorDal;
        }

        public void Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
        }

        public void Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
        }

        public List<CourseInstructor> GetAll()
        {
            return _courseInstructorDal.GetAll();
        }

        public void Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
        }

        public List<CourseInstructor> GetAllByCategoryId(int id)
        {
            return _courseInstructorDal.GetAll(x => x.Id == id);
        }
    }
}
