using MediatR;

namespace Application.Features.CourseInstructors.Commands.Create
{
    public class CreateCourseInstructorCommand : IRequest<CreatedCourseInstructorResponse>
    {
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
    }
}
