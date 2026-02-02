
namespace Conditionals
    {
        public enum Season
        {
            Spring,
            Autumn,
            Summer,
            Winter
        }

        class Program1
        {
            static void Main(string[] args)
            {
                var season = Season.Autumn;

                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("It's Spring! 🌸");
                        break;

                    case Season.Summer:
                        Console.WriteLine("It's Summer! ☀️");
                        break;

                    case Season.Autumn:
                        Console.WriteLine("It's Autumn! 🍂");
                        break;

                    case Season.Winter:
                        Console.WriteLine("It's Winter! ❄️");
                        break;

                    default:
                        Console.WriteLine("Unknown season.");
                        break;
                }
            }
        }
    }



   
