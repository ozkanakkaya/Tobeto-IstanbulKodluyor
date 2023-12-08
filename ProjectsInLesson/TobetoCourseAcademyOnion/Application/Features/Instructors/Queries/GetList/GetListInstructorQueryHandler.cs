using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Instructors.Queries.GetList
{
    public class GetListInstructorQueryHandler : IRequestHandler<GetListInstructorQuery, List<GetListInstructorResponse>>
    {
        IInstructorRepository _instructorRepository;
        IMapper _mapper;

        public GetListInstructorQueryHandler(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListInstructorResponse>> Handle(GetListInstructorQuery request, CancellationToken cancellationToken)
        {
            var instructors = await _instructorRepository.GetListAsync();

            return _mapper.Map<List<GetListInstructorResponse>>(instructors.Items);
        }
    }
}
