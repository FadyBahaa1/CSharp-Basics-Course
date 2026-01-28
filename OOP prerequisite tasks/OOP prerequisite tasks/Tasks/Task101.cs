using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task101
    {
        // Non-static Run method
        public void Run()
        {
            int[] numbers = new int[10];
           
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                int value;
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out value))
                    {
                        numbers[i] = value;
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a whole number (e.g., 42).");
                }
            }

            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;

            foreach (int n in numbers)
            {
                if (n > max) max = n;
                if (n < min) min = n;
                sum += n;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine();
            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // keeps the console open
        }
    }
}
