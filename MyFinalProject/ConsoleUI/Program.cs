using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


//ProductManager productManager = new ProductManager(new InMemoryProductDal());
ProductManager productManager = new ProductManager(new EFProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}