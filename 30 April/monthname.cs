using System;

class monthname
{
    static void Main()
    {
        int monthNumber = 5; // Change this as needed

        string[] months = { "January", "February", "March", "April", "May", "June", 
                            "July", "August", "September", "October", "November", "December" };

        Console.WriteLine(monthNumber >= 1 && monthNumber <= 12 
            ? "Month: " + months[monthNumber - 1] 
            : "Invalid month number");
    }
}
