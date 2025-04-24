
partial class Program
{
    static void HandleNullables()
    {
        //no es nullificable
        string firstName = "Dantee";

        //si es nullificable
        string? lastName = null;

        Console.WriteLine($"firstName: {firstName} lastName {lastName??"-"}");

        lastName = "Astudillo";        

        if(lastName != null){
            Console.WriteLine($"lastName: {lastName}");
        }
    }
}