using Domain.Entities;
using Tobeto.Core.Persistence.Repositories;

namespace Application.Services
{
    public interface ICourseInstructorRepository : IRepository<CourseInstructor, Guid>, IAsyncRepository<CourseInstructor, Guid>
    {
    }
}
