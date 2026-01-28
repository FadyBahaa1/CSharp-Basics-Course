using System;
using System.Collections.Generic;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task120
    {
        public void Run()
        {
            // 1️⃣ Create list
            List<int> numbers = new List<int>();

            // 2️⃣ Read 5 numbers from user
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            // 3️⃣ Call function to double numbers
            List<int> doubledNumbers = DoubleNumbers(numbers);

            // 4️⃣ Display result
            Console.WriteLine("\nDoubled numbers:");
            foreach (int num in doubledNumbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public List<int> DoubleNumbers(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int num in list)
            {
                result.Add(num * 2);
            }

            return result;
        }
    }
}
