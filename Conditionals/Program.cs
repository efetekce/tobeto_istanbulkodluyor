var number = 8;
//if (number == 8)
//{
//    Console.WriteLine("number is 8");
//}
//else if(number > 0)
//{
//    Console.WriteLine("number is greater than 0");
//}
//else
//{
//    Console.WriteLine("number is neither");
//}


//switch (number)
//{
//    case 10:
//        Console.WriteLine("number is 10");
//        break;
//    default:
//        Console.WriteLine("number is not 10");
//        break;
//}

//Console.WriteLine(number == 8 ? "number is 8" : "number is not 8");


if (number >= 0 && number <= 100)
{
    Console.WriteLine("number is between 0-100");
}
else if (number > 100 && number <= 200)
{
    Console.WriteLine("number is between 101-200");
}
else if (number > 200 || number < 0)
{
    Console.WriteLine("number is less than 0 or greater than 101-200");
}
Console.ReadLine();