using System;
using System.Collections.Generic;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task118
    {
        public void Run()
        {
            // 1️⃣ Create list and read numbers
            List<int> numbers = new List<int>();
            Console.WriteLine("Enter integers (10 numbers):");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            // 2️⃣ Calculate sum of even numbers
            int sumEven = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                    sumEven += num;
            }

            // 3️⃣ Display result
            Console.WriteLine($"\nSum of even numbers: {sumEven}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
