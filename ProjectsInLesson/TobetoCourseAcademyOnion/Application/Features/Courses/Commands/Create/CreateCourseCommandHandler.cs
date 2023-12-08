using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Courses.Commands.Create
{
    public class CreateCourseCommandHandler : IRequestHandler<CreateCourseCommand, CreatedCourseResponse>
    {
        ICourseRepository _courseRepository;
        IMapper _mapper;

        public CreateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCourseResponse> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = _mapper.Map<Course>(request);

            var createdCourse = await _courseRepository.AddAsync(course);

            return _mapper.Map<CreatedCourseResponse>(createdCourse);
        }
    }
}
