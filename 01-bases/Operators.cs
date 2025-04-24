
partial class Program
{
    static void Operators()
    {
        int number = 15;

        bool isEven = number % 2 == 0;

        bool isGreatherThanTen = number > 10;

        Console.WriteLine();

        if( isEven && isGreatherThanTen ){
            Console.WriteLine("Es par y mayor a 10");
        }else if(!isEven && isGreatherThanTen){
            Console.WriteLine("Es impar y mayor a 10");
        }else{
            Console.WriteLine("no es par ni mayor a 10");
        }

        //Operador ternario
        int age = 15;
        string category = age > 18 ? "Adulto" : "Menor";
        Console.WriteLine(category);
    }
}