using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        IResult Add(Category course);
        IResult Delete(Category course);
        IResult Update(Category course);
        IDataResult<List<Category>> GetAll();
        IDataResult<List<Category>> GetAllByCategoryId(int id);
        IDataResult<Category> GetById(int categoryId);
    }
}
