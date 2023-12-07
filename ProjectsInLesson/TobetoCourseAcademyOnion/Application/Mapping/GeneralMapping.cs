using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Delete;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateCategoryCommand, Category>().ReverseMap();
            CreateMap<CreatedCategoryResponse, Category>().ReverseMap();

            CreateMap<UpdateCategoryCommand, Category>().ReverseMap();
            CreateMap<UpdatedCategoryResponse, Category>().ReverseMap();

            CreateMap<DeleteCategoryCommand, Category>().ReverseMap();
            CreateMap<DeletedCategoryResponse, Category>().ReverseMap();

            CreateMap<GetByIdCategoryResponse, Category>().ReverseMap();

            CreateMap<GetListCategoryResponse, Category>().ReverseMap();
        }
    }
}
