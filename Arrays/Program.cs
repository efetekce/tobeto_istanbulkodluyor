
string[] students = new string[3];
students[0] = "Efe";
students[1] = "Efe";
students[2] = "Efe";
//string[] fruits = { "apple", "banana", "orange" };
//foreach (var fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}


string[,] regions = new string[4, 3]
{
    {"Istanbul", "Zonguldak", "Mersin" },
    {"Agri", "Usak", "Antep" },
    {"Izmir", "Ankara", "Antalya" },
    {"Kirklareli", "Adiyaman", "Mugla" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i, j]);
    }
    Console.WriteLine("////////////////");
}
Console.WriteLine();
Console.ReadLine();

