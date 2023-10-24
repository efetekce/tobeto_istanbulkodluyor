//WhileLoop();
//ForLoop();

string[] fruits = { "apple", "banana", "orange" };
foreach (var fruit in fruits)
{
    // we can not mutate elements in a foreach loop.
     //fruit[1]="dates"; this is read-only.
    Console.WriteLine(fruit);
}

int num = 10;

do
{
    Console.WriteLine(num);
    num--;
} while (num > 0);
//do executes once before the condition.
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