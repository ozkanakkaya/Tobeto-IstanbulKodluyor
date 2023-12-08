using MediatR;

namespace Application.Features.Courses.Queries.GetById
{
    public class GetByIdCourseQuery : IRequest<GetByIdCourseResponse>
    {
        public GetByIdCourseQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }


    }
}
