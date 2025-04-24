partial class Program
{
    static void StringTypes()
    {
        string name = "Dantee";
        string message = "Hello world from C# "+name;
        string interpolatedMessage = $"My message is: {message}";
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"var name has {name.Length} letters");
        Console.WriteLine($"name in uppercase {name.ToUpper()}");
        Console.WriteLine($"name in lowercas {name.ToLower()}");
        //Convert number to string
        int age = 26;
        Console.WriteLine($"number as string {age.ToString()}");
        //Convert bool to string
        bool status = true;
        Console.WriteLine($"status bool as string {status.ToString()}");

    }
}