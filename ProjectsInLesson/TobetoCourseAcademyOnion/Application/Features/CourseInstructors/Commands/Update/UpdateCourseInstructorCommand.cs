using MediatR;

namespace Application.Features.CourseInstructors.Commands.Update
{
    public class UpdateCourseInstructorCommand : IRequest<UpdatedCourseInstructorResponse>
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
    }
}
