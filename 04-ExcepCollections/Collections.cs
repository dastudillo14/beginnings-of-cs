
partial class Program{
    static void Collections()
    {
        List<string> names = ["Luis", "Pedro", "Juan"];
        names.Add("Dantee");
        ShowList(names);

        names.Remove("Luisx");

        WriteLine("------ After rm ------");
        ShowList(names);

        //Dictionary
        Dictionary<int, string> students = new()
        {
            {1,"Mauricio"},
            {2,"Leo"},
            {3,"Mary"},
            {4,"Pepe"},
        };

        students.Add(5, "Pedro");
        ShowDict(students);
        students.Remove(1);
        WriteLine("------ After rm ------");
        ShowDict(students);

        //Hashset
        HashSet<string> users = ["Pedro", "Juan", "Lucas"];
        users.Add("Pedro"); // no lo repite si ya existe
        ShowHashset(users);

    }

    private static void ShowHashset(HashSet<string> users)
    {
        foreach (var item in users)
        {
            WriteLine($"student {item}");
        }
    }

    private static void ShowDict(Dictionary<int, string> students)
    {
        foreach (var item in students)
        {
            WriteLine($"Llave {item.Key} - Valor: {item.Value}");
        }
    }

    private static void ShowList(List<string> names)
    {
        foreach (var item in names)
        {
            WriteLine($"Name -> {item}");
        }
    }
}