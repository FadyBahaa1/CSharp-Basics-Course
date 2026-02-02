using System;

namespace Exercises
{
    class Program8
    {
        static void Main(string[] args)
        {
            string name = "Mina Bahaa";

            // FOR LOOP
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("-----");

            // FOREACH LOOP
            foreach (char character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
