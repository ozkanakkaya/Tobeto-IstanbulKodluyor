using MediatR;

namespace Application.Features.Instructors.Commands.Create
{
    public class CreateInstructorCommand : IRequest<CreatedInstructorResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
