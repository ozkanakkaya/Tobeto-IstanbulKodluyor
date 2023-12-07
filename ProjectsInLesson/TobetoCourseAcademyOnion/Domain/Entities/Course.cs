using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class Course : Entity<Guid>
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }
        public ICollection<CourseInstructor> GetCourseInstructors { get; set; }
    }
}
