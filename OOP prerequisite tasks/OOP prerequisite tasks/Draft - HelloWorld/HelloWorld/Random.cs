using System;

namespace Exercises
{
    class Program89
    {
        static void Main(string[] args)
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                char c = (char)random.Next(97, 123);
                Console.WriteLine(c);
            }   
        }
    }
}

