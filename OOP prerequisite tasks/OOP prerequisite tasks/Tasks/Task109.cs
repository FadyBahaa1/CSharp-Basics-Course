using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task109
    {
        public void Run()
        {
            Console.Write("Enter first string (S1): ");
            string s1 = Console.ReadLine();

            Console.Write("Enter second string (S2): ");
            string s2 = Console.ReadLine();

            s1 = Concatenate(s1, s2);

            Console.WriteLine($"Result: {s1}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public string Concatenate(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
