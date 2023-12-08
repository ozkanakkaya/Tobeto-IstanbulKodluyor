using Application.Features.Instructors.Commands.Create;
using Application.Features.Instructors.Commands.Delete;
using Application.Features.Instructors.Commands.Update;
using Application.Features.Instructors.Queries.GetById;
using Application.Features.Instructors.Queries.GetList;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Instructors.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, CreateInstructorCommand>().ReverseMap();

            CreateMap<Instructor, DeletedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, DeleteInstructorCommand>().ReverseMap();

            CreateMap<Instructor, UpdatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, UpdateInstructorCommand>().ReverseMap();

            CreateMap<GetByIdInstructorResponse, Instructor>().ReverseMap();

            CreateMap<GetListInstructorResponse, Instructor>().ReverseMap();
        }
    }
}
