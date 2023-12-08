using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Instructors.Commands.Update
{
    public class UpdateInstructorCommandHandler : IRequestHandler<UpdateInstructorCommand, UpdatedInstructorResponse>
    {
        IInstructorRepository _instructorRepository;
        IMapper _mapper;

        public UpdateInstructorCommandHandler(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedInstructorResponse> Handle(UpdateInstructorCommand request, CancellationToken cancellationToken)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == request.Id);

            var updatedInstructor = await _instructorRepository.UpdateAsync(_mapper.Map(request, instructor));

            return _mapper.Map<UpdatedInstructorResponse>(updatedInstructor);
        }
    }
}
