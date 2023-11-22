﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator))]//Açıklaması aşağıda
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}

//[ValidationAspect(typeof(ProductValidator))]
//typeof(ProductValidator) ifadesi, ProductValidator sınıfının System.Type nesnesini döndürür. Bu Type nesnesi, ProductValidator sınıfı hakkında bilgi içerir ve bu sınıfın bir örneğini oluşturmak için kullanılabilir.

//System.Type nesnesi, bir sınıfın adı, namespace’i, içerdiği metotlar, özellikler, olaylar ve diğer üyeler gibi bilgileri içerir12345.Ayrıca, bir sınıfın hangi interfaceleri uyguladığı, hangi sınıftan türetildiği ve diğer tip bilgileri gibi bilgileri de içerir.

//typeof operatörü, derleme zamanında bilinen bir tipin System.Type nesnesini almak için kullanılır.Yani, typeof operatörü çalışma zamanında değil, derleme zamanında çalışır12345.Bu nedenle, typeof operatörü değişkenler veya örnekler üzerinde çalışmaz, sadece tipler üzerinde çalışır.

//Ayrıca, ProductValidator sınıfı AbstractValidator<Product> sınıfından türetilmiştir ve AbstractValidator<T> sınıfı IValidator interface’ini uygular. Bu nedenle, ProductValidator sınıfı dolaylı olarak IValidator interface’ini uygular ve bir IValidator tipi olarak kabul edilir.