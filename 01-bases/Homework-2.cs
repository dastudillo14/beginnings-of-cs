using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthdate = new DateTime(1999,04,14);
        TimeSpan difference = DateTime.Now - birthdate;
        Console.WriteLine($"llevas viviendo {difference.Days}");
    }

    static void DaysUntilNextBirthday()
    {
        Console.Write("Ingresa tu fecha de nacimiento (dd/MM/yyyy): ");
        string birthdateString = Console.ReadLine()!;
        DateTime birthdate = DateTime.ParseExact(birthdateString, "dd/MM/yyyy", CultureInfo.InvariantCulture );

        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthdate = new DateTime(currentDate.Year, birthdate.Month, birthdate.Day);
        
        if(nextBirthdate < currentDate){
            nextBirthdate = nextBirthdate.AddYears(1);
        }

        int days = (nextBirthdate - currentDate).Days;
        
        Console.WriteLine($"your birthdate will be in {days} days");
    }
}