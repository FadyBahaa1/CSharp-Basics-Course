internal class Task103
{
    public void Run()
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        string result = CheckDayType(day);
        Console.WriteLine($"The day is: {result}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public string CheckDayType(string day)
    {
        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                return "Weekday";

            case "Saturday":
            case "Sunday":
                return "Weekend";

            default:
                return "Invalid day";
        }
    }
}
