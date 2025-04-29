using System.Globalization;

partial class Program{
    static void ConverstionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        DateTime birthday = DateTime.Parse("2 Marzo 2025");
        WriteLine(birthday);
        WriteLine($"Formato extenso {birthday:D}");

    }
}