var number = 11;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10 or 20");

Console.ReadLine();