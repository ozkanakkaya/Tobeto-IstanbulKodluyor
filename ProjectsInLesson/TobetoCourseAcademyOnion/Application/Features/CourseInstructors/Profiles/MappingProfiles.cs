using Application.Features.CourseInstructors.Commands.Create;
using Application.Features.CourseInstructors.Commands.Delete;
using Application.Features.CourseInstructors.Commands.Update;
using Application.Features.CourseInstructors.Queries.GetById;
using Application.Features.CourseInstructors.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.CourseInstructors.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreateCourseInstructorCommand, CourseInstructor>().ReverseMap();
            CreateMap<CreatedCourseInstructorResponse, CourseInstructor>().ReverseMap();

            CreateMap<UpdateCourseInstructorCommand, CourseInstructor>().ReverseMap();
            CreateMap<UpdatedCourseInstructorResponse, CourseInstructor>().ReverseMap();

            CreateMap<DeleteCourseInstructorCommand, CourseInstructor>().ReverseMap();
            CreateMap<DeletedCourseInstructorResponse, CourseInstructor>().ReverseMap();

            CreateMap<GetByIdCourseInstructorResponse, CourseInstructor>().ReverseMap();

            CreateMap<GetListCourseInstructorResponse, CourseInstructor>().ReverseMap();
        }
    }
}
