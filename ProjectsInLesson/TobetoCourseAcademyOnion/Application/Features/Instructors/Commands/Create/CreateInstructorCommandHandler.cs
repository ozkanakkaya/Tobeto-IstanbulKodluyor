using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Instructors.Commands.Create
{
    public class CreateInstructorCommandHandler : IRequestHandler<CreateInstructorCommand, CreatedInstructorResponse>
    {
        IInstructorRepository _instructorRepository;
        IMapper _mapper;

        public CreateInstructorCommandHandler(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public async Task<CreatedInstructorResponse> Handle(CreateInstructorCommand request, CancellationToken cancellationToken)
        {
            var instructor = _mapper.Map<Instructor>(request);

            var createdInstructor = await _instructorRepository.AddAsync(instructor);

            return _mapper.Map<CreatedInstructorResponse>(createdInstructor);
        }
    }
}
