using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task106B
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
                double result = CalculateSquareRoot(number);
                Console.WriteLine($"Square root of {number} is: {result}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public double CalculateSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }
    }
}
