using System;

namespace Exercises
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the car speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;
                Console.WriteLine("Demerit points: " + demeritPoints);

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
            }
        }
    }
}
