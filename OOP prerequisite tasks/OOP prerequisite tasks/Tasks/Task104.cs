using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task104
    {
        public void Run()
        {
            int[] numbers = new int[10];
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("Enter 10 integer numbers:");

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

                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            // Calculate sum of even and odd numbers
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                    evenSum += n;
                else
                    oddSum += n;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of even numbers: {evenSum}");
            Console.WriteLine($"Sum of odd numbers: {oddSum}");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
