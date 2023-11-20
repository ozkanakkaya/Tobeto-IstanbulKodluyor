using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Add(courseInstructor);
            return new SuccessResult(Messages.CourseInstructorAdded);
        }

        public IResult Delete(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Delete(courseInstructor);
            return new SuccessResult(Messages.CourseInstructorDeleted);
        }

        public IDataResult<List<CourseInstructor>> GetAll()
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(), Messages.CourseInstructorsListed);
        }

        public IResult Update(CourseInstructor courseInstructor)
        {
            _courseInstructorDal.Update(courseInstructor);
            return new SuccessResult(Messages.CourseInstructorUpdated);
        }

        public IDataResult<List<CourseInstructor>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<CourseInstructor>>(_courseInstructorDal.GetAll(x => x.Id == id), Messages.CourseInstructorListed);
        }
        public IDataResult<CourseInstructor> GetById(int courseInstructorId)
        {
            return new SuccessDataResult<CourseInstructor>(_courseInstructorDal.Get(p => p.Id == courseInstructorId));
        }
    }
}
