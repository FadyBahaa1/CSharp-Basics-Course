using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task111
    {
        public void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int length = StringLength(input);

            Console.WriteLine($"Length of the string: {length}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        // Recursive function to calculate string length
        public int StringLength(string str)
        {
            if (str == "") // base case: empty string has length 0
                return 0;

            // recursive step: 1 (for first char) + length of rest of string
            return 1 + StringLength(str.Substring(1));
        }
    }
}
