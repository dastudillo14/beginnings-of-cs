
partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2020;

        string carInfo = car.ShowInfo();
        WriteLine(carInfo);

        car.ShowMessage("cambiaremos el modelo");

        car.ChangeModel("Spark");

        WriteLine(car.ShowInfo());

        Car.GeneralInfo();

        //Usando constructor
        Car sportCar = new Car("Honda",2025);
        WriteLine( sportCar.ShowInfo() );

        //Sintaxis simplificada
        Car collectionCar = new Car{
            Model = "Cadillac",
            Year = 1980
        };
        WriteLine(collectionCar.ShowInfo());

        //Lista de objetos
        List<Car> cars = new ()
        {
            new Car("Duster", 2023),
            new Car("Spark", 2019),
            new Car("StepWay", 2024)
        };


        WriteLine("----- Listado de carros ------");
        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }

    }
}



class Car
{
    public string? Model { get; set; }
    public int Year { get; set; }


    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public Car() { }

    //Destructores (~) : Sirve para liberar cosas sin uso
    ~Car()
    {
        WriteLine("Desestructor llamado, recurso liberado");
    }

    public void ChangeModel(string model)
    {
        Model = model;
    }

    public string ShowInfo()
    {
        return $"Auto -> modelo: {Model} - año: {Year}";
    }

    //Sobrecarga de métodos
    public void ShowMessage() => WriteLine("Este es un auto");
    public void ShowMessage(string message) => WriteLine(message);

    //Método estáticos
    public static void GeneralInfo()
    {
        WriteLine("El auto es uno de los transportes más utilizados.");
    }


}