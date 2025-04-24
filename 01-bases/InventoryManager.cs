
partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Teclado", "Mouse"];

        int[] stock = [10, 25, 30];

        double[] prices = [99.99, 2.50, 30.75];

        //Crear menú
        Console.WriteLine("1.- Comprar producto");
        Console.WriteLine("2.- Salir");
        Console.WriteLine("Ingrese su opción:");

        int optionSelected = int.Parse(Console.ReadLine()!);

        if (optionSelected == 1)
        {
            Console.WriteLine("Inventario de productos");
            Console.WriteLine("-----------------------");

            //Muestra listado de productos
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]} - Stock: {stock[i]}  - Precio: {prices[i]:C}");
            }

            Console.WriteLine("Ingrese el producto que desee comprar");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad que desea comprar");
            int quantity = int.Parse(Console.ReadLine()!);

            //Buscar producto y stock
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double? total = quantity * prices[i];
                        stock[i] -= quantity;
                        Console.WriteLine($"Precio a pagar por {searchedProduct} -> {total:C}");
                        Console.WriteLine($"Stock restante para el producto {searchedProduct} es {stock[i]} ");                        
                    }
                    else
                    {
                        Console.WriteLine($"No existe suficiente stock para el producto <{searchedProduct}>");
                        break;
                    }
                }
            }
        }else if(optionSelected == 2)
        {
            Console.WriteLine("Gracias por su visita");
        }else{
            Console.WriteLine("Opción incorrecta ");
        }

    }
}