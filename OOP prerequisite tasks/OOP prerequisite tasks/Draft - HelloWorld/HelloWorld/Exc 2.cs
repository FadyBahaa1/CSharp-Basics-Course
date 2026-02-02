using System;

namespace Exercises
{
    class Program3
    {
        static void M2ain(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = (num1 > num2) ? num1 : num2;
            Console.WriteLine("The maximum number is: " + max);
        }
    }
}
