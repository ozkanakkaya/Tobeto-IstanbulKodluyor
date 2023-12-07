using Application.Services;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Commands.Delete
{
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand, DeletedCategoryResponse>
    {
        ICategoryRepository _categoryRepository;
        IMapper _mapper;

        public DeleteCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<DeletedCategoryResponse> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetAsync(x => x.Id == request.Id);

            await _categoryRepository.DeleteAsync(category/*, true*/);//true ile kalıcı siler

            return _mapper.Map<DeletedCategoryResponse>(category);
        }
    }
}
