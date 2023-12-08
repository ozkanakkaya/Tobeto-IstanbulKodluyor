using Application.Services;
using Domain.Entities;
using Persistence.Contexts;
using Tobeto.Core.Persistence.Repositories;

namespace Persistence.Repositories
{
    public class InstructorRepository : EfRepositoryBase<Instructor, Guid, BaseDbContext>, IInstructorRepository
    {
        public InstructorRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
