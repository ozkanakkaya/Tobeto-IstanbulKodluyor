using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);

        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> GetById(int instructorId);
    }
}
