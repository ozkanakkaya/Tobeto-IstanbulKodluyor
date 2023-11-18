using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);

        IResult CourseAddWithInstructors(CourseAddDto courseAddDto);

        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<Course> GetById(int productId);
    }
}
