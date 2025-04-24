partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;
        Console.WriteLine($"x: {x}");
        Console.WriteLine($"y: {y}");
        Person person = new Person {Name = "Dantee"};
        Person person2 = person;
        person2.Name = "Alicia";

        Console.WriteLine($"person: {person.Name}");
        Console.WriteLine($"person2: {person2.Name}");

    }
}


class Person{
    public string? Name {get; set;}

}