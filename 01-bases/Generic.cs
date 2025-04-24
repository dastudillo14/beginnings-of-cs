partial class Program
{
    static void Generic()
    {
        string[] names = ["Juan", "Pepe", "Luis"];
        int[] numbers = [1, 2, 3, 4];
        //Usando métodos por cada tipo
        Console.WriteLine($"Tamaño de names es-> {GetStringArrayLength(names)}");
        Console.WriteLine($"Tamaño de numbers es-> {GetIntArrayLength(numbers)}");
        
        //Usando método que usa generic
        Console.WriteLine($"Tamaño de names es-> {GetArrayLength(names)}");
        Console.WriteLine($"Tamaño de numbers es-> {GetArrayLength(numbers)}");

        //Probando clase generic
        Box<int> boxNumber = new Box<int>{Content = 50 };
        Box<string> boxString = new Box<string>{Content = "Mensaje de bienvenida" };

        boxNumber.Show();
        boxString.Show();


    }


    //Métodos sin el uso de generic
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Método usando generic
    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }
}


class Box<T>
{
    public T? Content {get; set;}

    public void Show()
    {
        Console.WriteLine($"Contenido: {Content}");
    }
}