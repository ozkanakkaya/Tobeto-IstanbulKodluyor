using Application.Services;
using Domain.Entities;
using Persistence.Contexts;
using Tobeto.Core.Persistence.Repositories;

namespace Persistence.Repositories
{
    public class CourseRepository : EfRepositoryBase<Course, Guid, BaseDbContext>, ICourseRepository
    {
        public CourseRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
