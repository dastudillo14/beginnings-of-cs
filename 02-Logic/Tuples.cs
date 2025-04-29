
partial class Program{
    static void Tuples()
    {
        WriteLine("Tuple #1");
        (int, string) myTuple = (1,"Hello");
        WriteLine($"Número: {myTuple.Item1} - Texto: {myTuple.Item2}");

        WriteLine("Tuple #2");
        (int number, string text) myTuple2 = (1,"Hello");
        WriteLine($"Número: {myTuple2.number} - Texto: {myTuple2.text}");

        WriteLine("Tuple #3 - Operations");
        var (Sum, Substraction) = Operations(10,2); //Desestructuración.
        WriteLine($"Sum: {Sum} - Rest: {Substraction}");
    }

    static (int Sum, int Substraction) Operations( int a , int b)
    {
        return ( a+b , a-b);
    }
}