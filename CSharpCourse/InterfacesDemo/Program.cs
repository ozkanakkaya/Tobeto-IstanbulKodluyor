

IWorker[] workers = new IWorker[3]
{
    new Manager(),
    new Worker(),
    new Robot()
};

foreach (var worker in workers)
{
    worker.Work();
}

IEat[] eats = new IEat[2]
{
    new Manager(),
    new Worker()
};

foreach (var eat in eats)
{
    eat.Eat();
}

Console.ReadLine();

interface IWorker
{
    void Work();
}

interface IEat
{
    void Eat();
}

interface ISalary
{
    void GetSalary();
}

class Manager : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Yönetici Yemek yer");
    }

    public void GetSalary()
    {
        Console.WriteLine("Yönetici Maaş alır");
    }

    public void Work()
    {
        Console.WriteLine("Yönetici Çalışır");
    }
}

class Worker : IWorker, IEat, ISalary
{
    public void Eat()
    {
        Console.WriteLine("Çalışan Yemek yer");
    }

    public void GetSalary()
    {
        Console.WriteLine("Çalışan Maaş alır");
    }

    public void Work()
    {
        Console.WriteLine("Çalışan Çalışır");
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot Çalışır");
    }
}