using System;
class ExchangeIfGreater
{
    // Write an if-statement that takes two double variables (a) and (b) and exchanges their values if 
    // the first one is greater than the second one.
    //As a result print the values a and b, separated by a space.
    // Example: a=5,	b=2,	result= 2 5.
    static void Main()
    {
        Console.Write("Please anter number (a): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please anter number (b): ");
        int b = int.Parse(Console.ReadLine());
        int c;
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine( "The numbers after change : {0} and {1}" ,a,b);
    }
}
