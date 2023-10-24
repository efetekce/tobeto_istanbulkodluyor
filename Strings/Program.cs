string city = "Istanbul";
//Console.WriteLine(city[0]);
string city2 = "Antalya";
foreach (var item in city)
{
    Console.WriteLine(item);
}
Console.WriteLine(city + city2);
Console.WriteLine(String.Format("{1} {0}", city, city2));
Console.ReadLine();
