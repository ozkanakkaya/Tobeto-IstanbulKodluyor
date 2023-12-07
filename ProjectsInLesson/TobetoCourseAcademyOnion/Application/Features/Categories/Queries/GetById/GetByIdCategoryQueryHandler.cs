using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Queries.GetById
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQuery, GetByIdCategoryResponse>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<GetByIdCategoryResponse> Handle(GetByIdCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetAsync(x => x.Id == request.Id);
            return _mapper.Map<GetByIdCategoryResponse>(category);
        }
    }
}
