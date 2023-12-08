namespace Application.Features.CourseInstructors.Commands.Create
{
    public class CreatedCourseInstructorResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
