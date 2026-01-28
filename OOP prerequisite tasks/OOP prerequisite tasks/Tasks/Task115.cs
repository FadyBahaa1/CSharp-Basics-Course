using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task115
    {
        public void Run()
        {
            // 1️⃣ Define array
            int[] numbers = new int[10];

            // 2️⃣ Read 10 numbers from user
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // 3️⃣ Ask for value to remove
            Console.Write("Enter the value V to remove: ");
            int V = int.Parse(Console.ReadLine());

            // 4️⃣ Remove all occurrences of V and shift left
            int writeIndex = 0; // index to write the next number

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != V)
                {
                    numbers[writeIndex] = numbers[i];
                    writeIndex++;
                }
            }

            // Fill remaining elements with 0
            for (int i = writeIndex; i < numbers.Length; i++)
            {
                numbers[i] = 0;
            }

            // 5️⃣ Display updated array
            Console.WriteLine("\nArray after removing V:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
