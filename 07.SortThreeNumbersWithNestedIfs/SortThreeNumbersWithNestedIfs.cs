using System;
class SortThreeNumbersWithNestedIfs
{
    // Write a program that enters 3 real numbers and prints them sorted in descending order.
    // Use nested if statements.
    // Examples: a=5,	b=1,	c=2,	result= 5 2 1.
    static void Main()
    {
        Console.Write("Enter number (a): ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number (b): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter number (c): ");
        double c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.Write(a + ", ");
            if (b > c)
            {
                Console.Write(b + ", " + c);
            }
            else
            {
                Console.Write(c + ", " + b);
            }
        }
        else if (b > a && b > c)
        {
            Console.Write(b + ", ");
            if (a > c)
            {
                Console.Write(a + ", " + c);
            }
            else
            {
                Console.Write(c + ", " + a);
            }
        }
        else if (c > a && c > b)
        {
            Console.Write(c + ", ");
            if (a > b)
            {
                Console.Write(a + ", " + b);
            }
            else
            {
                Console.Write(b + ", " + a);
            }
        }
        Console.WriteLine();
    }
}
