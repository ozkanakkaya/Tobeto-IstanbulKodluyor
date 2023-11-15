using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetAllByCategoryId(int id);
    }
}
