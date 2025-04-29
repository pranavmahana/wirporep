using System;

public class addmultiplydivide
{
    // Method for Addition
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method for Subtraction
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Method for Multiplication
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // Method for Division
    static double Divide(int a, int b)
    {
        // Check to avoid division by zero
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero");
            return 0;
        }
        return (double)a / b;
    }

    static void Main()
    {
        int num1 = 20;
        int num2 = 10;

        // Calling the methods
        Console.WriteLine("Addition: " + Add(num1, num2));
        Console.WriteLine("Subtraction: " + Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + Multiply(num1, num2));
        Console.WriteLine("Division: " + Divide(num1, num2));
    }
}
