namespace Application.Features.CourseInstructors.Commands.Delete
{
    public class DeletedCourseInstructorResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
    }
}
