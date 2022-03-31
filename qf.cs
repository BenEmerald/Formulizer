using System;

public class Formulizer
{
	public static void Main()
	{
        int a;
        int b;
        int c;

        string answer;

        Console.WriteLine("Hello, welcome to the quadratic formulizer!");

        for ( ; ; )
        {
            Console.WriteLine("Please enter a value for A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a value for B:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a value for C:");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your solutions are " + Formula(a, b, c, true) + " and " + Formula(a, b, c, false) + "!");

            Console.WriteLine("Would you like to continue? [Y/N]");

            answer = Console.ReadLine();

            if (answer == "Y" || answer == "y")
            {
                continue;
            }
            else if (answer == "N" || answer == "n")
            {
                break;
            }
        }
	}

	static double Formula(int x, int y, int z, bool which)
    {
        if (which)
        {
            return ((y*-1)+(Math.Sqrt((y*y)+(-4*x*z))))/(2*x);
        }
        else if (!which)
        {
            return ((y*-1)-(Math.Sqrt((y*y)+(-4*x*z))))/(2*x);
        }
        else
        {
            return 0;
        }
    }
}
