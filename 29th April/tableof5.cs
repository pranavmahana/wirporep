using System;

public class tableof5
{
    public static void Main()
    {
        int number = 5;

        Console.WriteLine("Multiplication Table of " + number + ":");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number + " × " + i + " = " + (number * i));
        }
    }
}
