using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            // Ask for the first number
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Ask for the operation
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Ask for the second number
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            // Decide what to do based on operator
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("❌ Cannot divide by zero!");
                    break;
                default:
                    Console.WriteLine("❌ Invalid operator!");
                    return;
            }

            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");
        }
    }
}
