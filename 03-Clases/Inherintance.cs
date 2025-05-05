
partial class Program
{
    static void Inherintance()
    {
        HogwartsStudent student = new(){
            Name = "Harry Potter",
            House = "Gryffindor"
        };

        HogwartsTeacher teacher = new(){
            Name ="Severus",
            Subject = "Pociones"
        };
        
        student.Greet();
        student.ShowHouse();

        teacher.Greet();
        teacher.ShowSubject();
    }
}

//Clase padre
public class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}

//Clase hijo
public class HogwartsStudent : Character
{
    public string? House { get; set; }

    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Hogwarts");
    }

    public override void Greet()
    {
        //base.Greet();
        WriteLine($"Saludos, soy {Name} y soy estudiante");
    }
}

//Clase hijo
public class HogwartsTeacher : Character
{
    public string? Subject { get; set; }

    public void ShowSubject()
    {
        WriteLine($"Enseño {Subject} en Hogwarts");
    }

       public override void Greet()
    {
        //base.Greet();
        WriteLine($"Hola a tod@s, soy {Name} y soy profesor");
    }
}