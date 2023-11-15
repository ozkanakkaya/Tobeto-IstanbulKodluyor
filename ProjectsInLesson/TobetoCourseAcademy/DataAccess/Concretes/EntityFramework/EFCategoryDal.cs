using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes.EntityFramework
{
    public class EFCategoryDal : EFEntityRepositoryBase<Category, TobetoCourseAcademyContext>, ICategoryDal
    {
     
    }
}
