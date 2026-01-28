using System;
using System.Linq; // for frequency count using LINQ

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task110
    {
        public void Run()
        {
            int[] numbers = new int[10];

            // Step 1: Read 10 integers
            Console.WriteLine("Enter 10 integer numbers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                int value;
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Invalid input. Enter a valid integer: ");
                }
                numbers[i] = value;
            }

            // Step 2: Find smallest and greatest
            int min = numbers[0];
            int max = numbers[0];
            foreach (int n in numbers)
            {
                if (n < min) min = n;
                if (n > max) max = n;
            }

            // Step 3: Calculate difference using a function
            int difference = CalculateDifference(min, max);

            // Step 4: Find most frequent value
            int mostFrequent = numbers
                .GroupBy(n => n)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;

            // Step 5: Display results
            Console.WriteLine("\nEntered numbers: " + string.Join(", ", numbers));
            Console.WriteLine($"Difference between greatest and smallest: {difference}");
            Console.WriteLine($"Most frequent value: {mostFrequent}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public int CalculateDifference(int a, int b)
        {
            return b - a;
        }
    }
}
