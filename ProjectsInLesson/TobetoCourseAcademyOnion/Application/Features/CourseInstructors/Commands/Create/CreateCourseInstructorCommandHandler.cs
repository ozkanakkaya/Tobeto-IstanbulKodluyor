using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.CourseInstructors.Commands.Create
{
    public class CreateCourseInstructorCommandHandler : IRequestHandler<CreateCourseInstructorCommand, CreatedCourseInstructorResponse>
    {
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public CreateCourseInstructorCommandHandler(ICourseInstructorRepository courseInstructorRepository, IMapper mapper)
        {
            _courseInstructorRepository = courseInstructorRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCourseInstructorResponse> Handle(CreateCourseInstructorCommand request, CancellationToken cancellationToken)
        {
            var courseInstructor = _mapper.Map<CourseInstructor>(request);

            var createdCourseInstructor = await _courseInstructorRepository.AddAsync(courseInstructor);

            return _mapper.Map<CreatedCourseInstructorResponse>(createdCourseInstructor);
        }
    }
}
