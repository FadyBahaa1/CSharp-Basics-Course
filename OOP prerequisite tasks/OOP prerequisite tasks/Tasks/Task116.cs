using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task116
    {
        public void Run()
        {
            int size = 5;   // size of each array

            int[] a = new int[size];
            int[] b = new int[size];
            int[] c = new int[size * 2];

            // Read array A
            Console.WriteLine("Enter sorted values for array A:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"A[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            // Read array B
            Console.WriteLine("\nEnter sorted values for array B:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"B[{i}]: ");
                b[i] = int.Parse(Console.ReadLine());
            }

            // Merge arrays
            int iA = 0, iB = 0, iC = 0;

            while (iA < size && iB < size)
            {
                if (a[iA] <= b[iB])
                {
                    c[iC] = a[iA];
                    iA++;
                }
                else
                {
                    c[iC] = b[iB];
                    iB++;
                }
                iC++;
            }

            // Copy remaining elements of A
            while (iA < size)
            {
                c[iC] = a[iA];
                iA++;
                iC++;
            }

            // Copy remaining elements of B
            while (iB < size)
            {
                c[iC] = b[iB];
                iB++;
                iC++;
            }

            // Print result
            Console.WriteLine("\nMerged sorted array C:");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
