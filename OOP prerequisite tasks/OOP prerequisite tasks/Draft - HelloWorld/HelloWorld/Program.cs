// See https://aka.ms/new-console-template for more information
using System;

namespace MyFirstProject
{
    class Program2
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It is Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It is Afternoon");
            }
            else
            {
                Console.WriteLine("It is Evening");
            }

            bool isGoldcustomer = true;

            float price = (isGoldcustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}

