using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concretes
{
    public class EfInstructorDal : EFEntityRepositoryBase<Instructor, TobetoCourseAcademyContext>, IInstructorDal
    {

    }
}
