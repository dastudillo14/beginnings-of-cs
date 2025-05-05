
partial class Program
{
    static void ProductSalesDemo()
    {
        Invetory invetory = new();

        Product p1 = new Product("Laptop", 1999.99, 100);
        Product p2 = new Product("Mouse", 20, 10);

        invetory.AddProduct(p1);
        invetory.AddProduct(p2);

        invetory.ShowInventory();

    }
}


class Product
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }


    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }

    public void ShowInfo()
    {
        WriteLine($"Producto: {Name} - Precio: {Price} - Stock: {Stock}");
    }

    public bool Sell(int quantity)
    {
        if (quantity <= Stock)
        {
            Stock -= quantity;
            WriteLine($"Venta realizada de {Name}, se vendieron {quantity} unidades");
            return true;
        }

        WriteLine($"Stock insuficiente para {Name}");
        return false;
    }

}

class Invetory
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
        WriteLine($"Nuevo producto agregado {product.Name}");
    }

    public void ShowInventory()
    {
        WriteLine($"Inventario de productos ({products.Count})");
        foreach (var item in products)
        {
            item.ShowInfo();
        }
    }
}