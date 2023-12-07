using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Instructor : Entity<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<CourseInstructor> GetCourseInstructors { get; set; }
    }
}
