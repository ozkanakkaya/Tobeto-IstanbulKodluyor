using OOP1;

Product product1 = new Product();
product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;

Product product2 = new Product
{
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalen",
    UnitPrice = 35
};

ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName); 
int number = 100;
productManager.DoSometing(number); 
Console.WriteLine(number); //100

productManager.Topla2(3, 6);

//int, double, bool... değer tiptir.
//diziler, class, abstract class, interface... referans tiptir.