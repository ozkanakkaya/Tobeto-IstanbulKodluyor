using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);

        List<Course> GetAll();
    }
}
