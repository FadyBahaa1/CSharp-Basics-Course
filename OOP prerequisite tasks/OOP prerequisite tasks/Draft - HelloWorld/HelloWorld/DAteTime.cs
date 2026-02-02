using System;

class Program7812
{
    static void Main()
    {
        // Create a specific date
        var date = new DateTime(2024, 11, 14);

        // Get current system date and time
        var now = DateTime.Now;

        Console.WriteLine("Specific date: " + date);
        Console.WriteLine("Current date & time: " + now);
        Console.WriteLine(now.ToLongDateString());

    }

}
