using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services
{
    public interface ICourseRepository : IRepository<Course, Guid>, IAsyncRepository<Course, Guid>
    {
    }
}
