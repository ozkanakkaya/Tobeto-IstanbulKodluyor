using Classes;

CustomerManager customerManager= new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager= new ProductManager();
productManager.Add();
productManager.Update();


Customer customer= new Customer();
customer.Id = 1;
customer.FirstName = "Özkan";
customer.LastName = "Akkaya";
customer.City = "İstanbul";

Customer customer1 = new Customer
{
    Id = 2,
    FirstName = "Özkan1",
    LastName = "Akkaya1",
    City = "Giresun"
};

Console.WriteLine(customer1.FirstName);

Console.ReadLine();
