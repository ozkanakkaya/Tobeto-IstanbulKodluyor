using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Queries.GetList
{
    public class GetListCategoryQueryHandler : IRequestHandler<GetListCategoryQuery, List<GetListCategoryResponse>>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public GetListCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<List<GetListCategoryResponse>> Handle(GetListCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetListAsync();

            //Mapping
            //var categoryList = new List<GetListCategoryResponse>();
            //foreach (var category in categories.Items)
            //{
            //    categoryList.Add(new GetListCategoryResponse()
            //    {
            //        Id = category.Id,
            //        Name = category.Name,
            //        CreatedDate = category.CreatedDate,
            //        DeletedDate = category.DeletedDate,
            //        UpdatedDate = category.UpdatedDate
            //    });
            //}

            return _mapper.Map<List<GetListCategoryResponse>>(categories.Items);
        }
    }
}
