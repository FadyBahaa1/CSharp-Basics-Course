using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task112
    {
        public void Run()
        {
            char[] chars = new char[10];

            Console.WriteLine("Enter 10 characters:");

            // Read 10 characters
            for (int i = 0; i < chars.Length; i++)
            {
                string input;
                while (true)
                {
                    Console.Write($"Character {i + 1}: ");
                    input = Console.ReadLine();

                    if (!string.IsNullOrEmpty(input) && input.Length == 1)
                    {
                        chars[i] = input[0];
                        break;
                    }

                    Console.WriteLine("Invalid input. Please enter a single character.");
                }
            }

            // Search for 'z'
            int position = -1; // default: not found
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'z')
                {
                    position = i;
                    break; // stop at first occurrence
                }
            }

            // Display result
            if (position != -1)
                Console.WriteLine($"Character 'z' found at position {position + 1}");
            else
                Console.WriteLine("Character 'z' not found.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
