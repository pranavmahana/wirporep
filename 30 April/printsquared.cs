using System;

public class printsquared
{
    public static void Main()
    {
    for (int i = 1; ; i++)
{
    int square = i * i;
    if (square > 100)
        break;
    Console.WriteLine("Square of " + i + " is " + square);
}

    }
}
