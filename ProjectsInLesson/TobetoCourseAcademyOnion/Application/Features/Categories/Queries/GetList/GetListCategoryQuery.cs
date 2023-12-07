using MediatR;

namespace Application.Features.Categories.Queries.GetList
{
    public class GetListCategoryQuery : IRequest<List<GetListCategoryResponse>>
    {
    }
}
