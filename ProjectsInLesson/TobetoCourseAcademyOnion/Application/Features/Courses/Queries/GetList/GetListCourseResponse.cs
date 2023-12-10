using Application.Features.Instructors.Dtos;

namespace Application.Features.Courses.Queries.GetList
{
    public class GetListCourseResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public IList<InstructorDto> Instructors { get; set; }
    }
}
