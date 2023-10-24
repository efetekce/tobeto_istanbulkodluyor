//StringIntro();

string sentence = "Getting good at c#";

var result = sentence.Length;
var result2 = sentence.Clone();
sentence = "Syntax is similar to javascript";
bool result3 = sentence.EndsWith("p");
bool result4 = sentence.StartsWith("my name");
var result5 = sentence.IndexOf("similar");
var result6 = sentence.IndexOf(" ");
var result7 = sentence.LastIndexOf(" ");
var result8 = sentence.Insert(0, "See? ");
var result9 = sentence.Substring(3, 4);
var result10 = sentence.ToUpper();
var result11 = sentence.Replace(" ", "-");
var result13 = sentence.Remove(1);
Console.WriteLine(result2);
Console.WriteLine(sentence);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7);
Console.WriteLine(result8);
Console.WriteLine(result9);
Console.WriteLine(result10);
Console.WriteLine(result11);
Console.WriteLine(result13);

Console.ReadLine();

//static void StringIntro()
//{
//    string city = "Istanbul";
//    //Console.WriteLine(city[0]);
//    string city2 = "Antalya";
//    foreach (var item in city)
//    {
//        Console.WriteLine(item);
//    }
//    Console.WriteLine(city + city2);
//    Console.WriteLine(String.Format("{1} {0}", city, city2));
//    Console.ReadLine();
//}
