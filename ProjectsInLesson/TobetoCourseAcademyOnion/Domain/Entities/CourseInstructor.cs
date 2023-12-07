using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class CourseInstructor : Entity<Guid>
    {
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }

        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}
