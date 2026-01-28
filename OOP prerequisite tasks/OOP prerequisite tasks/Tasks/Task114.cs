using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task114
    {
        public void Run()
        {
            int[,] matrix = new int[3, 4]; // 3 rows, 4 columns

            // 1️⃣ Read matrix from user
            Console.WriteLine("Enter values for 3x4 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Enter value at [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // 2️⃣ Ask user for the number to find
            Console.Write("Enter a number to search: ");
            int target = int.Parse(Console.ReadLine());

            // 3️⃣ Search for the number
            bool found = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        Console.WriteLine($"Number {target} found at position: row {i + 1}, column {j + 1}");
                        found = true;
                        break; // stop inner loop if found
                    }
                }
                if (found)
                    break; // stop outer loop if found
            }

            if (!found)
                Console.WriteLine("Number not found.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
