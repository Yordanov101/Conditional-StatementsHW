using System;
class PlayWithIntDoubleAndString
{
    // Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    // If the variable is int or double, the program increases it by one.
    // If the variable is a string, the program appends * at the end.
    // Print the result at the console. Use switch statement.
    // Examples:       program	                   user
    //                     Please choose a type:	
    //                     1 --> int	
    //                     2 --> double	
    //                     3--> string	             3
    // Please enter a string:	hello              hello*
                                                   	
    static void Main()
    {
        Console.Write("Please enter a digit  for choose a type (0-3): ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1: type = 1;
                Console.Write("Please enter a integer digit: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("output: "+ (a+1));
                break;
            case 2: type = 2;
                Console.Write("Please enter a double digit: ");
                double b = double.Parse(Console.ReadLine() + 1);
                Console.WriteLine("output:"+ (b+1));
                break;
            case 3: Console.Write("Please enter a string: ");
                string c = (Console.ReadLine() +"*");
                Console.WriteLine("output: "+ c);
                break;
            default: Console.WriteLine("not a valid digit for choose type");
                break;
        }
    }
}
