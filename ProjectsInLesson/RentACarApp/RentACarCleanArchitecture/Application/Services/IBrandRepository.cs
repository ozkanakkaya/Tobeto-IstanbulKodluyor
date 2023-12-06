using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services
{
    public interface IBrandRepository : IRepository<Brand, Guid>, IAsyncRepository<Brand, Guid>
    {
    }
}
