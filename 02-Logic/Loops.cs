
partial class Program
{
    static void Loops()
    {
        //While
        int counter = 1;
        while (counter <= 5)
        {
            WriteLine($"Iteración - while {counter}");
            counter++;
        }

        // do while
        int number = 0;
        do
        {
            WriteLine($"Iteración - do while {number}");
            number++;
        } while (number < 3);

        //for
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteración - for {i}");
        }

        //for-each
        string[] list = ["pera", "manzana", "uva", "piña"];
        foreach (var item in list)
        {
            WriteLine($"fruta -> {item}");
        }

        List<string> names = ["Pedro", "Dantee", "Luis"];
        foreach (var name in names)
        {
            WriteLine($"name -> {name}");
        }

    }
}