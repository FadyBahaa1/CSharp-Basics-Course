using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task105
    {
        public void Run()
        {
            Console.Write("Enter how many numbers you want to input (N): ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input. Enter a positive integer: ");
            }

            int evenCount = 0;
            int oddCount = 0;

            int maxEven = int.MinValue;
            int maxOdd = int.MinValue;

            Console.WriteLine();
            Console.WriteLine($"Enter {n} integer numbers:");

            for (int i = 0; i < n; i++)
            {
                int value;

                // Validate each number
                while (true)
                {
                    Console.Write($"Enter number {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out value))
                        break;

                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }

                // Check even or odd
                if (value % 2 == 0)
                {
                    evenCount++;

                    if (value > maxEven)
                        maxEven = value;
                }
                else
                {
                    oddCount++;

                    if (value > maxOdd)
                        maxOdd = value;
                }
            }

            Console.WriteLine();

            // Print results
            Console.WriteLine($"Even numbers count: {evenCount}");
            Console.WriteLine($"Odd numbers count: {oddCount}");

            if (evenCount > 0)
                Console.WriteLine($"Maximum even number: {maxEven}");
            else
                Console.WriteLine("No even numbers were entered.");

            if (oddCount > 0)
                Console.WriteLine($"Maximum odd number: {maxOdd}");
            else
                Console.WriteLine("No odd numbers were entered.");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
