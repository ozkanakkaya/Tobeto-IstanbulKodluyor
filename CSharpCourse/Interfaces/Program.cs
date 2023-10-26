

PersonManager manager = new PersonManager();
Customer customer = new Customer
{
    Id = 1,
    FirstName = "Özkan",
    LastName = "Akkaya",
    Address = "İstanbul"
};

Student student = new Student
{
    Id = 1,
    FirstName = "Özkan1",
    LastName = "Akkaya1",
    Departmant = "Software",
};

manager.Add(customer);
manager.Add(student);


interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}


class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
}

class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class Worker : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Departmant { get; set; }
}

class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}