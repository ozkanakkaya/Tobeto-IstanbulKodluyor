Add();
Add();
var result = Add2(10);
Console.WriteLine(result);

Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added!");
}

static int Add2(int number1, int number2=30)//default değerler en sonda olmalı
{
    var result = number1 + number2;
    return result;
}