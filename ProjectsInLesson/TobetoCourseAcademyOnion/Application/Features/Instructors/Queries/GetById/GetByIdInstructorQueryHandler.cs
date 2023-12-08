using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Instructors.Queries.GetById
{
    public class GetByIdInstructorQueryHandler : IRequestHandler<GetByIdInstructorQuery, GetByIdInstructorResponse>
    {
        IInstructorRepository _instructorRepository;
        IMapper _mapper;

        public GetByIdInstructorQueryHandler(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdInstructorResponse> Handle(GetByIdInstructorQuery request, CancellationToken cancellationToken)
        {
            var instructor = await _instructorRepository.GetAsync(x => x.Id == request.Id);
            return _mapper.Map<GetByIdInstructorResponse>(instructor);
        }
    }
}
