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

            CreateMap<Course, GetByIdCourseResponse>()
                .ForPath(dest => dest.Instructors, opt => opt.
                    MapFrom(src => src.GetCourseInstructors.
                        Select(x=>x.Instructor)))
                .ReverseMap();

            CreateMap<Course, GetListCourseResponse>()
                .ForPath(dest => dest.CategoryName, opt => opt
                    .MapFrom(src => src.Category.Name))
                .ForPath(dest => dest.Instructors, opt => opt.
                    MapFrom(src => src.GetCourseInstructors.
                        Select(x => x.Instructor)))
                .ReverseMap();
        }
    }
}
