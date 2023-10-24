Add();
var result = Plus(2,4);
Console.WriteLine(result);
Console.WriteLine(Plus(33, 5));
//directly outputting the function
Console.ReadLine();

static void Add()
{
    Console.WriteLine("Added");
}

static int Plus(int n1, int n2=22)
{
    return n1 + n2;
}
//working with default parameters
