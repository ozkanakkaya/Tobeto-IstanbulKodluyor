using MediatR;

namespace Application.Features.Courses.Commands.Create
{
    public class CreateCourseCommand : IRequest<CreatedCourseResponse>
    {
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
