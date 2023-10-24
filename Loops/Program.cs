//WhileLoop();
//ForLoop();
//DoWhileLoop();

string[] fruits = { "apple", "banana", "orange" };
//ForEachLoop(fruits);

if (IsPrimeNumber(9))
{
    Console.WriteLine("this is a prime number");

}
else
{
    Console.WriteLine("this is not a prime number");
}


Console.ReadLine();


static void ForLoop()
{
    for (int i = 255; i > 10; i -= 4)
    {
        Console.WriteLine(i);
    }
}

static void WhileLoop()
{
    int a = 98;
    while (a > 0)
    {
        Console.WriteLine(a);
        a--;
    }
}

static void ForEachLoop(string[] fruits)
{
    foreach (var fruit in fruits)
    {
        // we can not mutate elements in a foreach loop.
        //fruit[1]="dates"; this is read-only.
        Console.WriteLine(fruit);
    }
}

static void DoWhileLoop()
{
    int num = 10;

    do
    {
        Console.WriteLine(num);
        num--;
    } while (num > 0);
    //do executes once before the condition.
}

static bool IsPrimeNumber(int n)
{
    bool result = true;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            result = false;
        }
    }
    return result;
}