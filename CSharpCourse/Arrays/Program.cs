string[] students = new String[3] { "Özkan", "Özkan2", "Özkan3" };
string[] studens2 = { "Özkan", "Özkan2", "Özkan3" };
//studens2[3] = "Ahmet";

//foreach (var student in studens2)
//{
//    Console.WriteLine(student);
//}

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmit","Balıkesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"İzmir","Muğla","Manisa" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("***************");
}

Console.ReadLine();