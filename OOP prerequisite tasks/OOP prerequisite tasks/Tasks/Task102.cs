using System;

namespace OOP_prerequisite_tasks.Tasks
{
    internal class Task102
    {
        public void Run()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            string result = CheckNumber(num);
            Console.WriteLine($"The number is: {result}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        public string CheckNumber(int number)
        {
            if (number > 0)
                return "Positive";
            else if (number < 0)
                return "Negative";
            else
                return "Zero";
        }
    }
}
