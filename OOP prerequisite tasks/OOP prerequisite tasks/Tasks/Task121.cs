using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task121
    {
        public void Run()
        {
            // 1️⃣ Create a 3x3 array
            int[,] matrix = new int[3, 3];

            // 2️⃣ Read values from user
            Console.WriteLine("Enter 9 integers for 3x3 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Value at [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // 3️⃣ Call function to check negatives
            bool hasNegative = ContainsNegative(matrix);

            // 4️⃣ Display result
            Console.WriteLine($"\nMatrix contains negative number? {hasNegative}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public bool ContainsNegative(int[,] array)
        {
            // Check each element
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                        return true; // Found a negative
                }
            }
            return false; // No negatives found
        }
    }
}
