using MediatR;

namespace Application.Features.Courses.Queries.GetList
{
    public class GetListCourseQuery : IRequest<List<GetListCourseResponse>>
    {
    }
}
