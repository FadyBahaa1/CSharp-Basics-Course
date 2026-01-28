using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task108
    {
        public void Run()
        {
            Console.Write("Enter first string: ");
            string first = Console.ReadLine();

            Console.Write("Enter second string: ");
            string second = Console.ReadLine();

            int result = IsPartOf(first, second);

            Console.WriteLine($"Result: {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public int IsPartOf(string first, string second)
        {
            if (second.Contains(first))
                return 1;
            else
                return 0;
        }
    }
}
