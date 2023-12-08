using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.CourseInstructors.Queries.GetById
{
    public class GetByIdCourseInstructorQueryHandler : IRequestHandler<GetByIdCourseInstructorQuery, GetByIdCourseInstructorResponse>
    {
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public GetByIdCourseInstructorQueryHandler(ICourseInstructorRepository courseInstructorRepository, IMapper mapper)
        {
            _courseInstructorRepository = courseInstructorRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdCourseInstructorResponse> Handle(GetByIdCourseInstructorQuery request, CancellationToken cancellationToken)
        {
            var result = await _courseInstructorRepository.GetAsync(x => x.Id == request.Id);
            return _mapper.Map<GetByIdCourseInstructorResponse>(result);
        }
    }
}
