using System;

public class dayofweek
{
    public static void Main()
    {
        int day = 4; // You can change this value

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid number! Please enter a number from 1 to 7.");
                break;
        }
    }
}
