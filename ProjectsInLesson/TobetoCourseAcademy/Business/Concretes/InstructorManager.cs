using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);

        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(), Messages.InstructorsListed);
        }

        public IResult Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
            return new SuccessResult(Messages.InstructorUpdated);

        }

        public IDataResult<Instructor> GetById(int instructorId)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(p => p.Id == instructorId));
        }
    }
}

