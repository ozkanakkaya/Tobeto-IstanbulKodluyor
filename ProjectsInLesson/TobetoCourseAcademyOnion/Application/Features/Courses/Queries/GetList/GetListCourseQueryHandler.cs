using Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Courses.Queries.GetList
{
    public class GetListCourseQueryHandler : IRequestHandler<GetListCourseQuery, List<GetListCourseResponse>>
    {
        ICourseRepository _courseRepository;
        IMapper _mapper;

        public GetListCourseQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListCourseResponse>> Handle(GetListCourseQuery request, CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetListAsync(
                include: query => query
                    .Include(entity => entity.Category)
                    .Include(entity => entity.GetCourseInstructors)
                    .ThenInclude(entity => entity.Instructor));

            return _mapper.Map<List<GetListCourseResponse>>(courses.Items);
        }
    }
}
