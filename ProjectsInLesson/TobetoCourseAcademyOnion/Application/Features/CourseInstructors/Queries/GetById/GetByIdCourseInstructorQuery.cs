using MediatR;

namespace Application.Features.CourseInstructors.Queries.GetById
{
    public class GetByIdCourseInstructorQuery : IRequest<GetByIdCourseInstructorResponse>
    {
        public GetByIdCourseInstructorQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }


    }
}
