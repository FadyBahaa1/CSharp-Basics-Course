using System;
using System.Collections.Generic;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task119
    {
        public void Run()
        {
            // 1️⃣ Create list of strings
            List<string> words = new List<string>();

            // 2️⃣ Read 5 words from user
            Console.WriteLine("Enter 5 words:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Word {i + 1}: ");
                words.Add(Console.ReadLine());
            }

            // 3️⃣ Ask for word to search
            Console.Write("Enter word to search: ");
            string searchWord = Console.ReadLine();

            // 4️⃣ Check if word exists
            bool exists = WordExists(words, searchWord);

            // 5️⃣ Display result
            Console.WriteLine($"Word exists: {exists}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public bool WordExists(List<string> list, string word)
        {
            foreach (string item in list)
            {
                if (item == word)   // case-sensitive comparison
                    return true;
            }
            return false;
        }
    }
}
