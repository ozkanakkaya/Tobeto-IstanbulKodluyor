using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Courses.Commands.Update
{
    public class UpdateCourseCommandHandler : IRequestHandler<UpdateCourseCommand, UpdatedCourseResponse>
    {
        ICourseRepository _courseRepository;
        IMapper _mapper;

        public UpdateCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedCourseResponse> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetAsync(x => x.Id == request.Id);

            var updatedCourse = await _courseRepository.UpdateAsync(_mapper.Map(request, course));

            return _mapper.Map<UpdatedCourseResponse>(updatedCourse);
        }
    }
}
