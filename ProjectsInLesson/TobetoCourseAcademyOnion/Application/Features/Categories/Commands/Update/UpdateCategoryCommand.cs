using MediatR;

namespace Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommand : IRequest<UpdatedCategoryResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
