using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.CourseInstructors.Commands.Update
{
    public class UpdateCourseInstructorCommandHandler : IRequestHandler<UpdateCourseInstructorCommand, UpdatedCourseInstructorResponse>
    {
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public UpdateCourseInstructorCommandHandler(ICourseInstructorRepository courseInstructorRepository, IMapper mapper)
        {
            _courseInstructorRepository = courseInstructorRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedCourseInstructorResponse> Handle(UpdateCourseInstructorCommand request, CancellationToken cancellationToken)
        {
            var result = await _courseInstructorRepository.GetAsync(x => x.Id == request.Id);

            var updatedCategory = await _courseInstructorRepository.UpdateAsync(_mapper.Map(request, result));

            return _mapper.Map<UpdatedCourseInstructorResponse>(updatedCategory);
        }
    }
}
