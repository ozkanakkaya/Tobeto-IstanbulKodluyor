//ForLoop();
//WhileLoop();
//DoWhileLoop();
//ForEachLoop();

if (IsPrimeNumber(7))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}
Console.ReadLine();

static bool IsPrimeNumber(int number)
{
    bool result = true;
    for (int i = 2; i < number - 1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}!", number);

    Console.ReadLine();
}

static void ForLoop()
{
    for (int i = 100; i >= 0; i = i - 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");

    Console.ReadLine();
}

static void DoWhileLoop()
{
    int number = 100;
    do
    {
        Console.WriteLine(number);
        number--;
    } while (number >= 11);
    Console.ReadLine();
}

static void ForEachLoop()
{
    string[] students = new String[3] { "Özkan", "Özkan2", "Özkan3" };

    foreach (var student in students)
    {
        Console.WriteLine(student);
    }
    Console.ReadLine();
}