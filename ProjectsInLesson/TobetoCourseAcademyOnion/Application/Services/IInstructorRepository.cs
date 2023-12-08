using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services
{
    public interface IInstructorRepository : IRepository<Instructor, Guid>, IAsyncRepository<Instructor, Guid>
    {
    }
}
