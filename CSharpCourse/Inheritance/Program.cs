
Person[] persons=new Person[3]
{
    new Customer
    {
        FirstName="Özkan"
    },
    new Student
    {
        FirstName="Özkan1"
    },
    new Person
    {
        FirstName="Özkan2"
    }
};

foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}




class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer: Person
{
    public string City { get; set; }
}

class Student: Person
{
    public string Department { get; set; }
}