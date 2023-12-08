using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.CourseInstructors.Queries.GetList
{
    public class GetListCourseInstructorQueryHandler : IRequestHandler<GetListCourseInstructorQuery, List<GetListCourseInstructorResponse>>
    {
        ICourseInstructorRepository _courseInstructorRepository;
        IMapper _mapper;

        public GetListCourseInstructorQueryHandler(ICourseInstructorRepository courseInstructorRepository, IMapper mapper)
        {
            _courseInstructorRepository = courseInstructorRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListCourseInstructorResponse>> Handle(GetListCourseInstructorQuery request, CancellationToken cancellationToken)
        {
            var result = await _courseInstructorRepository.GetListAsync();

            return _mapper.Map<List<GetListCourseInstructorResponse>>(result.Items);
        }
    }
}
