using MediatR;

namespace Application.Features.Courses.Commands.Delete
{
    public class DeleteCourseCommand : IRequest<DeletedCourseResponse>
    {
        public DeleteCourseCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
