using System;

namespace Exercises
{
    class Program76
    {
        static void Main(string[] args)
        {
            // Even numbers from 0 to 10
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("---- Reverse ----");

            // Even numbers from 10 down to 0
            for (int i = 10; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
