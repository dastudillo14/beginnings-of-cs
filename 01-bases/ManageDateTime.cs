partial class Program
{
    static void ManageDateTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(1999, 4, 14); //yyyy, mm, day
        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine(now);
        Console.WriteLine(today);
        Console.WriteLine(oneWeekAgo);
        Console.WriteLine(customDate);
        Console.WriteLine(weekDay);


    }
}