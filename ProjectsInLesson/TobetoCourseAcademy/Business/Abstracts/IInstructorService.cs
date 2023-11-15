using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);

        List<Instructor> GetAll();
    }
}
