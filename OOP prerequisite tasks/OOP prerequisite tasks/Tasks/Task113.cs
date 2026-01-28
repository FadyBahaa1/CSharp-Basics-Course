using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task113
    {
        public void Run()
        {
            int[,] A = new int[3, 3];
            int[,] B = new int[3, 3];
            int[,] C_Add = new int[3, 3];
            int[,] C_Sub = new int[3, 3];

            Console.WriteLine("Enter values for Matrix A:");
            ReadMatrix(A);

            Console.WriteLine("\nEnter values for Matrix B:");
            ReadMatrix(B);

            // Add and subtract matrices
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C_Add[i, j] = A[i, j] + B[i, j];
                    C_Sub[i, j] = A[i, j] - B[i, j];
                }
            }

            Console.WriteLine("\nMatrix A:");
            PrintMatrix(A);

            Console.WriteLine("\nMatrix B:");
            PrintMatrix(B);

            Console.WriteLine("\nA + B:");
            PrintMatrix(C_Add);

            Console.WriteLine("\nA - B:");
            PrintMatrix(C_Sub);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter value at [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
