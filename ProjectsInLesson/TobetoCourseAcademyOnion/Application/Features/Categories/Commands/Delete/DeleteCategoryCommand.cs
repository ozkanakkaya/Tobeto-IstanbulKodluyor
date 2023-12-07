using MediatR;

namespace Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommand : IRequest<DeletedCategoryResponse>
    {
        public DeleteCategoryCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
