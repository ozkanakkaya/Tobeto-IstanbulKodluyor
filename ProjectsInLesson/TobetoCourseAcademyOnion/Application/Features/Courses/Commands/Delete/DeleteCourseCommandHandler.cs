using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Courses.Commands.Delete
{
    public class DeleteCourseCommandHandler : IRequestHandler<DeleteCourseCommand, DeletedCourseResponse>
    {
        ICourseRepository _courseRepository;
        IMapper _mapper;

        public DeleteCourseCommandHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<DeletedCourseResponse> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetAsync(x => x.Id == request.Id);

            await _courseRepository.DeleteAsync(course/*, true*/);

            return _mapper.Map<DeletedCourseResponse>(course);
        }
    }
}
