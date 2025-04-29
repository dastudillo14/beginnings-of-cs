
partial class Program
{
    static void Conditionals()
    {
        int age = 10;
        if (age >= 18)
        {
            WriteLine("Eres mayor de edad");
        }
        else
        {
            WriteLine("No eres mayor de edad");
        }

        //Operador ternario
        string message = age >= 19 ? "Eres mayor de edad" : "No eres mayor de edad";
        WriteLine(message);

        //Else-if
        int temperature = 36;

        if (temperature > 35)
        {
            WriteLine("Mucho calor");
        }
        else if (temperature >= 20)
        {
            WriteLine("Agradable");
        }
        else
        {
            WriteLine("Hace frío");
        }

        //Switch
        int day = 43;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            case 3:
                WriteLine("Miércoles");
                break;
            default:
                WriteLine("No válido");
                break;
        }

        //Switch con expresiones - Lambda
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            _ => "no válido"
        };

        WriteLine(dayMessage);
    }
}