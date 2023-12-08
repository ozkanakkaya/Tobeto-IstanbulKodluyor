namespace Application.Features.CourseInstructors.Commands.Update
{
    public class UpdatedCourseInstructorResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
