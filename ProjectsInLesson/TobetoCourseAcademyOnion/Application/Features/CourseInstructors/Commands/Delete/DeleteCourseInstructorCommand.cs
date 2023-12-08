using MediatR;

namespace Application.Features.CourseInstructors.Commands.Delete
{
    public class DeleteCourseInstructorCommand : IRequest<DeletedCourseInstructorResponse>
    {
        public DeleteCourseInstructorCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
