using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task107
    {
        public void Run()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integer numbers:");

            // Read 10 numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                int value;

                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Invalid input. Enter a valid integer: ");
                }

                numbers[i] = value;
            }

            // Assume first number is the maximum
            int max = numbers[0];

            // Find the maximum
            foreach (int n in numbers)
            {
                if (n > max)
                {
                    max = n;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Maximum number is: {max}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
