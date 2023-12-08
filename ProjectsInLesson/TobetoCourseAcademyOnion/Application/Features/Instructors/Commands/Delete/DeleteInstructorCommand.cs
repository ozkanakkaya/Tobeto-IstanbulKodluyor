using MediatR;

namespace Application.Features.Instructors.Commands.Delete
{
    public class DeleteInstructorCommand : IRequest<DeletedInstructorResponse>
    {
        public DeleteInstructorCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
