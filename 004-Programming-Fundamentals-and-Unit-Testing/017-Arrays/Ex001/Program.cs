namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var days = new string[7];

        days[0] = "Monday";
        days[1] = "Tuesday";
        days[2] = "Wednesday";
        days[3] = "Thursday";
        days[4] = "Friday";
        days[5] = "Saturday";
        days[5] = "Sunday";

        string[] moreDays =
        [
            "Invalid day!",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        ];

        var currentDay = int.Parse(Console.ReadLine());

        Console.WriteLine(currentDay is >= 1 and <= 7 ? moreDays[currentDay] : moreDays[0]);
    }
}