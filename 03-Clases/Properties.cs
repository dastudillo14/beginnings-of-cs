
partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Species = "Lobo";
        animal.Age = 10;

        WriteLine($"Animal - Habitat: {animal.Habitat} - Especie: {animal.Species} - Edad: {animal.Age}");
    }
}

class Animal
{
    public string Species { get; set; } = "Desconocida";
    public string Category { get; } = "Vertebrado";
    private int age;

    //Validación de setter para Age
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentNullException("Age no puede ser negativa");
            }
            age = value;
        }
    }

    public Animal(string habitat)
    {
        Habitat = habitat;
    }
    public string Habitat { get; }


}