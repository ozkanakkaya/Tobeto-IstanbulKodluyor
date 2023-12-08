using Application.Features.Courses.Commands.Create;
using Application.Features.Courses.Commands.Delete;
using Application.Features.Courses.Commands.Update;
using Application.Features.Courses.Queries.GetById;
using Application.Features.Courses.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Courses.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Course, CreatedCourseResponse>().ReverseMap();
            CreateMap<Course, CreateCourseCommand>().ReverseMap();

            CreateMap<Course, DeletedCourseResponse>().ReverseMap();
            CreateMap<Course, DeleteCourseCommand>().ReverseMap();

            CreateMap<Course, UpdatedCourseResponse>().ReverseMap();
            CreateMap<Course, UpdateCourseCommand>().ReverseMap();

            CreateMap<GetByIdCourseResponse, Course>().ReverseMap();

            CreateMap<GetListCourseResponse, Course>().ReverseMap().ForPath(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
        }
    }
}
