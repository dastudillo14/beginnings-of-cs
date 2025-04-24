partial class Program
{
    static void DataStructures()
    {
        //Clases
        User user = new User { Name = "Dantee", Age = 26 };
        user.Greet();

        //Estructura
        Point point = new Point{X=30, Y=20};
        System.Console.WriteLine($"Punto eje x-> {point.X} y-> {point.Y}");

        //Record
        CellPhone cellPhone = new CellPhone("Nokia255",2024);
        System.Console.WriteLine($"modelo: {cellPhone.Model} - año: {cellPhone.Year}");
    }
}

class User
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo {Age} años");
    }

}

struct Point
{
    public int X {get;set;}
    public int Y {get;set;}

}


record CellPhone(string Model, int Year);
