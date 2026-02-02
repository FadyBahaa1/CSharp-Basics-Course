using System;
using System.Collections.Generic;

class Program33333
{
    static void Main()
    {
        var numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter a number or 'Quit' to exit: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
                break;

            int num;
            if (!int.TryParse(input, out num))
            {
                Console.WriteLine("Invalid number, try again.");
                continue;
            }

            numbers.Add(num);
        }

        var uniqueNumbers = new HashSet<int>(numbers);
        Console.WriteLine("Unique numbers: " + string.Join(", ", uniqueNumbers));
    }
}
