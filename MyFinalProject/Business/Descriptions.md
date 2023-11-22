
 ### [ProductManager.cs](Business/Concrete/ProductManager.cs)
```
[ValidationAspect(typeof(ProductValidator))]
public IResult Add(Product product)
{
    _productDal.Add(product);
    return new SuccessResult(Messages.ProductAdded);
}
```
`typeof(ProductValidator)` ifadesi, `ProductValidator` sınıfının `System.Type` nesnesini döndürür. Bu Type nesnesi, `ProductValidator` sınıfı hakkında bilgi içerir ve bu sınıfın bir örneğini oluşturmak için kullanılabilir.

`System.Type` nesnesi, bir sınıfın adı, namespace’i, içerdiği metotlar, özellikler, olaylar ve diğer üyeler gibi bilgileri içerir12345.Ayrıca, bir sınıfın hangi interfaceleri uyguladığı, hangi sınıftan türetildiği ve diğer tip bilgileri gibi bilgileri de içerir.

`typeof()` operatörü, derleme zamanında bilinen bir tipin `System.Type` nesnesini almak için kullanılır.Yani, typeof operatörü çalışma zamanında değil, derleme zamanında çalışır.Bu nedenle, typeof operatörü değişkenler veya örnekler üzerinde çalışmaz, sadece tipler üzerinde çalışır.

Ayrıca, `ProductValidator` sınıfı `AbstractValidator<Product>` sınıfından türetilmiştir ve `AbstractValidator<T>` sınıfı
`IValidator` interface’ini uygular. Bu nedenle, `ProductValidator` sınıfı dolaylı olarak `IValidator` interface’ini uygular ve bir `IValidator` tipi olarak kabul edilir.

