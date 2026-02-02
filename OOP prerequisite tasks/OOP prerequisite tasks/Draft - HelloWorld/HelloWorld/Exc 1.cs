


namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 10: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
