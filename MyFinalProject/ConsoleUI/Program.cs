﻿using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



//ProductManager productManager = new ProductManager(new InMemoryProductDal());
ProductManager productManager = new ProductManager(new EFProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}