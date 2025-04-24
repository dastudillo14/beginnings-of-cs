partial class Program
{
    static void ListDictionary()
    {
        List<string> names = new List<string> { "Mauricio", "Juan", "Nick" };
        System.Console.WriteLine($"Total de nombres es: {names.Count}");

        //Agregar elemento
        names.Add("Luis");

        System.Console.WriteLine($"Total de nombres es: {names.Count}");

        foreach (var item in names)
        {
            System.Console.WriteLine($"name: {item}");
        }

        //Remover elementos
        names.Remove("Luis");

        bool isPresent = names.Contains("Luis");

        Console.WriteLine($"Luis está en la lista ? {isPresent}");


        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>{
            {1,"Dantee"},
            {2,"Mauricio"},
            {3,"Michael"},
            {4,"Nico"},
            {5,"Alex"}
        };

        foreach (var item in students)
        {
            System.Console.WriteLine($"Student: key: {item.Key} - value: {item.Value}");
        }
    }

}