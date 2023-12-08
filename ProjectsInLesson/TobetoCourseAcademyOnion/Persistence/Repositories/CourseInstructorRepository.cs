using Application.Services;
using Domain.Entities;
using Persistence.Contexts;
using Tobeto.Core.Persistence.Repositories;

namespace Persistence.Repositories
{
    public class CourseInstructorRepository : EfRepositoryBase<CourseInstructor, Guid, BaseDbContext>, ICourseInstructorRepository
    {
        public CourseInstructorRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
