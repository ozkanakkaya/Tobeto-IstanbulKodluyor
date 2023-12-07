using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Commands.Update
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, UpdatedCategoryResponse>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<UpdatedCategoryResponse> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {/*_mapper.Map<Category>(request);*/
            var category = await _categoryRepository.GetAsync(x => x.Id == request.Id);

            category = _mapper.Map(request, category);

            var updatedCategory = await _categoryRepository.UpdateAsync(category);

            return _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
        }
    }
}
