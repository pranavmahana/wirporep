using System;

public class largestnumber
{
    public static void Main()
    {
        int a = 12, b = 25, c = 18;

        if (a >= b && a >= c)
        {
            Console.WriteLine("Largest number is: " + a);
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("Largest number is: " + b);
        }
        else
        {
            Console.WriteLine("Largest number is: " + c);
        }
    }
}
