//Add();
//Add();
//var result = Add2(10);

int number1 = 20;
int number2 = 100;
/*var result2 = Add3(ref number1, number2);*/ //ref keywordü değer tipleri referans tip gibi kullanabilmesi sağlar.
var result2 = Add3(out number1, number2); //reften farkı başlangıç değeri olması lazım ve değişken bir kere set edilmiş olması gerekir.
Console.WriteLine(result2);
Console.WriteLine(number1);

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

static int Add3(out int number1, int number2)
{
    number1 = 30;
    return  number1 + number2;

}