using System;

public class oddeven
{
    public static void Main()
    {
        int number = 7; // You can change this value to test with other numbers

        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is Even");
        }
        else
        {
            Console.WriteLine(number + " is Odd");
        }
    }
}
