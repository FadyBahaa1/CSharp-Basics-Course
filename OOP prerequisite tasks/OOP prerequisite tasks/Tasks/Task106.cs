using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task106
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            double number;

            // Validate input
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Enter a valid number: ");
            }

            if (number < 0)
            {
                Console.WriteLine("Square root of a negative number is not a real number.");
            }
            else
            {
                // Calculate square root directly inside Run()
                double result = Math.Sqrt(number);
                Console.WriteLine($"Square root of {number} is: {result}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
