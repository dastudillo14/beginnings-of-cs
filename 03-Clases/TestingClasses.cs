

partial class Program
{
    static void TestingClass()
    {
        Vehicle vehicle = new Vehicle();
        vehicle.Brand = "Toyota";
        vehicle.Model = "Fortuner";
        vehicle.Year = 2025;

        vehicle.ShowInfo();

        Vehicle vehicle1 = new()
        {
            Brand = "Honda",
            Model = "Civic",
            Year = 2000
        };

        vehicle1.ShowInfo();

        Vehicle vehicle2 = new Vehicle("Chevrolet", "Spark GT", 2012);
        vehicle2.ShowInfo();


    }
}


class Vehicle
{
    //Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    //constructor
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    //constructor opcional
    public Vehicle() { }


    public void ShowInfo()
    {
        WriteLine($"Este vehículo es un {Brand} {Model} del año {Year} \n");
    }
    //Métodos
}