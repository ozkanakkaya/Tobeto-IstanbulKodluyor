using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


//ProductTest();
CategoryTest();

//GetAllProducts();


static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EFProductDal());

    var result = productManager.GetProductDetails();

    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }


}
//ProductManager productManager = new ProductManager(new InMemoryProductDal());
static void GetAllProducts()
{
    ProductManager productManager = new ProductManager(new EFProductDal());

    foreach (var product in productManager.GetAll().Data)
    {
        Console.WriteLine(product.ProductName);
    }
}
