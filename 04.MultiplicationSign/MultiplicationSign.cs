using System;
class MultiplicationSign
{
    // Write a program that shows the sign (+, - or 0) of the product of three real numbers,
    // without calculating it.Use a sequence of if operators.
    // Examples : a=5,	b=2,	c=2,	result= + .     a=-2,	b=-2,	c=1,	result= + .  
    static void Main()
    {
        Console.Write("Please anter number (a): ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please anter number (b): ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please anter number (c): ");
        double c = double.Parse(Console.ReadLine());

        int d = 0;

        if((a==0)||(b==0)||(c==0))
        {
            Console.WriteLine("The result is 0");
        }
        else
        {
            if(a<0)
            {
                d++;
            }
            if(b<0)
            {
                d++;
            }
            if(c<0)
            {
                d++;
            }
            if (d % 2 == 0)
            {
                Console.WriteLine("The result is +");
            }
            else
            {
                Console.WriteLine("The result is -");
            }
        }
    }
}
