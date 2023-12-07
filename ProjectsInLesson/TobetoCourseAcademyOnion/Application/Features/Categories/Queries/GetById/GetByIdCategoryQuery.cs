using MediatR;

namespace Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQuery : IRequest<GetByIdCategoryResponse>
    {
        public GetByIdCategoryQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }


    }
}
