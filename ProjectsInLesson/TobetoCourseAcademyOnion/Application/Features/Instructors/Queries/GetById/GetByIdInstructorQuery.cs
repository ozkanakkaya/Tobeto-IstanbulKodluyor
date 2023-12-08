using MediatR;

namespace Application.Features.Instructors.Queries.GetById
{
    public class GetByIdInstructorQuery : IRequest<GetByIdInstructorResponse>
    {
        public GetByIdInstructorQuery(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }


    }
}
