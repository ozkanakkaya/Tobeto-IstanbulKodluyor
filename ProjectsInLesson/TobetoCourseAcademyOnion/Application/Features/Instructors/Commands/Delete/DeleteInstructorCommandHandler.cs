using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Instructors.Commands.Delete
{
    public class DeleteInstructorCommandHandler : IRequestHandler<DeleteInstructorCommand, DeletedInstructorResponse>
    {
        IInstructorRepository _instructorRepository;
        IMapper _mapper;

        public DeleteInstructorCommandHandler(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public async Task<DeletedInstructorResponse> Handle(DeleteInstructorCommand request, CancellationToken cancellationToken)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == request.Id);

            await _instructorRepository.DeleteAsync(instructor/*, true*/);

            return _mapper.Map<DeletedInstructorResponse>(instructor);
        }
    }
}
