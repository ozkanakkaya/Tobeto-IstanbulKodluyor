using MediatR;

namespace Application.Features.Instructors.Commands.Update
{
    public class UpdateInstructorCommand : IRequest<UpdatedInstructorResponse>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
