using System;
using System.Collections.Generic;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task117
    {
        public void Run()
        {
            // 1️⃣ Create a list and read numbers from user
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            // 2️⃣ Get positive numbers
            List<int> positiveNumbers = GetPositiveNumbers(numbers);

            // 3️⃣ Display positive numbers
            Console.WriteLine("\nPositive numbers:");
            foreach (int num in positiveNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Function that filters positive numbers
        public List<int> GetPositiveNumbers(List<int> list)
        {
            List<int> positives = new List<int>();
            foreach (int num in list)
            {
                if (num > 0)
                {
                    positives.Add(num);
                }
            }
            return positives;
        }
    }
}
