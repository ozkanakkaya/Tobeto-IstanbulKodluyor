using MediatR;

namespace Application.Features.Instructors.Queries.GetList
{
    public class GetListInstructorQuery : IRequest<List<GetListInstructorResponse>>
    {
    }
}
