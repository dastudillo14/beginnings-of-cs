
partial class Program
{
    static void AbstractClassExamples()
    {
        WashingMachine washingMachine = new()
        {
            Brand = "ElectroLux"
        };

        washingMachine.TurnOn();
        washingMachine.ShowBrand();

    }
}


abstract class HomeAppliance
{
    public string? Brand { get; set; }

    public abstract void TurnOn();

    public void ShowBrand()
    {
        WriteLine($"La marca del electrodoméstico es-> {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("Encendiendo lavadora...");
    }
}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("Encendiendo microhondas...");
    }
}

