partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Precio unitario: {unitPrice}");
        Console.WriteLine($"Cantitdad vendida: {quantitySold}");
        Console.WriteLine($"Total vendido: {totalAmount:C}");
    }

    static void SalaryReport()
    {   
        Console.Write($"Ingrese su nombre: ");
        string? name = Console.ReadLine();
        
        Console.Write("Ingrese el número de horas trabajadas: ");
        int hoursWorked = Int32.Parse(Console.ReadLine());

        Console.Write($"Ingrese su salario por hora: ");
        double salary = double.Parse(Console.ReadLine()!);

        string message = $"El salario para {name} es { hoursWorked * salary }";

        Console.WriteLine(message);

    }
}