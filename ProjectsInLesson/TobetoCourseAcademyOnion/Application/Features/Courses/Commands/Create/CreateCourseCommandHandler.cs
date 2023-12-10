using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Courses.Commands.Create
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CreatedCourseResponse>
    {
        ICourseRepository _courseRepository;
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper, ICourseInstructorRepository courseInstructorRepository)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
            _courseInstructorRepository = courseInstructorRepository;
        }

        public async Task<CreatedCourseResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request);

            var createdCourse = await _courseRepository.AddAsync(course);

            if (request.InstructorIds != null)
            {
                course.GetCourseInstructors = new List<CourseInstructor>();

                foreach (var instructorId in request.InstructorIds)
                {
                    course.GetCourseInstructors.Add(new CourseInstructor()
                    {
                        CourseId = course.Id,
                        InstructorId = instructorId
                    });
                }

                await _courseInstructorRepository.AddRangeAsync(course.GetCourseInstructors);

                return _mapper.Map<CreatedCourseResponse>(createdCourse);
            }

            return _mapper.Map<CreatedCourseResponse>(createdCourse);
        }
    }
}
