using MediatR;

namespace Application.Features.CourseInstructors.Queries.GetList
{
    public class GetListCourseInstructorQuery : IRequest<List<GetListCourseInstructorResponse>>
    {
    }
}
