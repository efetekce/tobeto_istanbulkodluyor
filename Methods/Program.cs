﻿Add();
var result = Plus(2,4);
Console.WriteLine(result);
Console.WriteLine(Plus(33, 5));
//directly outputting the function
int n1 = 1;
int n2 = 44;
var result2 = Plus3(ref n1, n2);
Console.WriteLine(result2);
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

static int Plus3(ref int n1,int n2)
{
    n1 = 30;
    return n1 + n2;
}