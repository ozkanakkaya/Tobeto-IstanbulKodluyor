using Application.Services;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Courses.Queries.GetById
{
    public class GetByIdCourseQueryHandler : IRequestHandler<GetByIdCourseQuery, GetByIdCourseResponse>
    {
        ICourseRepository _courseRepository;
        IMapper _mapper;

        public GetByIdCourseQueryHandler(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdCourseResponse> Handle(GetByIdCourseQuery request, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetAsync(
                x => x.Id == request.Id, 
                include: query => query
                    .Include(entity => entity.GetCourseInstructors)
                    .ThenInclude(entity => entity.Instructor));

            return _mapper.Map<GetByIdCourseResponse>(course);
        }
    }
}
