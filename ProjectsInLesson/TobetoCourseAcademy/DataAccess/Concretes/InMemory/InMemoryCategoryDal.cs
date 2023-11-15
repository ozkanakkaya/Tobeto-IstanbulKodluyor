using DataAccess.Abstracts;
using Entities.Concretes;
using System.Linq.Expressions;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category> {
                        new Category{Id=1, Name="Otomotiv" },
                        new Category{Id=2, Name="Kırtasiye" },
                            new Category{Id=3, Name="Yazılım" },
                            new Category{Id=4, Name="Blog" },

                        };
        }
        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            Category categoryToDelete = _categories.SingleOrDefault(p => p.Id == entity.Id);//LINQ
            _categories.Remove(categoryToDelete);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _categories;
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(p => p.Id == category.Id);
            categoryToUpdate.Name = category.Name;
        }
    }
}
