﻿using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    //buna generic constrains denir
    //class burada referans tip olduğunu ifade eder.
    //IEntity : IEntity veya IEntity iplemente eden bir nesne olabilir anlamını taşır.
    //new() :  newlenebilir olmalıdır. Bu sayede T, IEntity olamaz.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
