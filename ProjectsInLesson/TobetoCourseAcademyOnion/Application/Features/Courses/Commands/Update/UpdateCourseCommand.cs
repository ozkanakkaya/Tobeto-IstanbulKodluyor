using MediatR;

namespace Application.Features.Courses.Commands.Update
{
    public class UpdateCourseCommand : IRequest<UpdatedCourseResponse>
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
    }
}
