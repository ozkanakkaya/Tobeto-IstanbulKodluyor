using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.CourseInstructors.Commands.Delete
{
    public class DeleteCourseInstructorCommandHandler : IRequestHandler<DeleteCourseInstructorCommand, DeletedCourseInstructorResponse>
    {
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public DeleteCourseInstructorCommandHandler(ICourseInstructorRepository courseInstructorRepository, IMapper mapper)
        {
            _courseInstructorRepository = courseInstructorRepository;
            _mapper = mapper;
        }

        public async Task<DeletedCourseInstructorResponse> Handle(DeleteCourseInstructorCommand request, CancellationToken cancellationToken)
        {
            var result = await _courseInstructorRepository.GetAsync(x => x.Id == request.Id);

            await _courseInstructorRepository.DeleteAsync(result/*, true*/);//true ile kalıcı siler

            return _mapper.Map<DeletedCourseInstructorResponse>(result);
        }
    }
}
