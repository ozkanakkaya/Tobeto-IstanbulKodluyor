using AutoMapper;
using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        IMapper _mapper;
        public CourseManager(ICourseDal courseDal, IMapper mapper)
        {
            _courseDal = courseDal;
            _mapper = mapper;
        }

        public IResult Add(Course course)
        {
            if (course.Name.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.CourseNameInvalid);
            }
            _courseDal.Add(course);

            return new SuccessResult(Messages.CourseAdded);
            
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);

        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CoursesListed);
        }

        public IDataResult<Course> GetById(int courseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(p => p.Id == courseId));
        }

        public IDataResult<List<Course>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(x => x.Price >= min && x.Price <= max));

        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<CourseDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);
        }

        public IResult CourseAddWithInstructors(CourseAddDto courseAddDto)
        {
            var course = _mapper.Map<Course>(courseAddDto);

            course.GetCourseInstructors = new List<CourseInstructor>();

            foreach (var instructorId in courseAddDto.InstructorIds)
            {
                course.GetCourseInstructors.Add(new CourseInstructor
                {
                    Course = course,
                    InstructorId = instructorId
                });
            }

            _courseDal.Add(course);

            return new SuccessResult(Messages.CourseAddedWithInstructors);

        }
    }
}

