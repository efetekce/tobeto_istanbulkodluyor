

//Console.WriteLine("Hello, World!");
// Console.ReadLine() waits for a user input.

// value types
double number5 = 10.4;
decimal number6 = -200.3333333333m;


char character = 'e';
// char type can converted into int type(ascii value).
string city = "Istanbul";
bool condition = true;
byte number4 = 0;
// byte type can hold a value between 0 and 255.
short number3 = -32768;
// can't assign decimals to an integer.
int number1 = 10;
// all data types have limits to their values.
long number2 = 324893423423412312;
var number7 = 34;
number7 = 'b';

Console.WriteLine("Number 1 is {0}", number1);
Console.WriteLine("Number 2 is {0}", number2);
Console.WriteLine("Number 3 is {0}", number3);
Console.WriteLine("Number 4 is {0}", number4);
Console.WriteLine("Number 5 is {0}", number5);
Console.WriteLine("Number 6 is {0}", number6);
Console.WriteLine("Character is: {0}", character);
Console.WriteLine((int)Week.Wednesday);
// type conversion
Console.ReadLine();
enum Week
{
    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
} 