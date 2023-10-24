//StringIntro();

string sentence = "Getting good at c#";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "Syntax is similar to javascript";

static void StringIntro()
{
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
}
