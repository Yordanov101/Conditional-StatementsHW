using System;
class Program
{
    // Write a program that finds the biggest of three numbers.
    // Examples: a=5,	b=2,	c=2,	biggest=5.
    static void Main()
    {
        Console.Write("Enter number (a) : ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number (b) : ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number (c) : ");
        double c = double.Parse(Console.ReadLine());
        double biggest;

        if (a > b)
        {
            biggest = a;
        }
        else
        {
            biggest = b;
        }

        if (biggest > c)
        {
            Console.WriteLine("The biggest number is: " + biggest);
        }
        else
        {
            Console.WriteLine("The biggest numberis : " + c);
        }
    }
}
