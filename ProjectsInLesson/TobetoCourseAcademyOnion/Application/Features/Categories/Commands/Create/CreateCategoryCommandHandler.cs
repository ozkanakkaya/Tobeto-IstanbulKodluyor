using Application.Services;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Categories.Commands.Create
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);

            var createdCategory = await _categoryRepository.AddAsync(category);

            return _mapper.Map<CreatedCategoryResponse>(createdCategory);
        }
    }
}
