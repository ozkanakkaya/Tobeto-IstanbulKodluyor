string[] students = new String[3] { "Özkan", "Özkan2", "Özkan3" };
string[] studens2 = { "Özkan", "Özkan2", "Özkan3" };
//studens2[3] = "Ahmet";

foreach (var student in studens2)
{
    Console.WriteLine(student);
}

Console.WriteLine();
Console.ReadLine();