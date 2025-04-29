
partial class Program
{
    static void AnonymousLambda()
    {
        WriteLine($"square -> {square(5)}");
        WriteLine($"lambdaSquare -> {lambdaSquare(5)}");

        List<int> numbers = [1,2,3,4,5];
        var evenNumbers = numbers.Where(n=> n % 2 == 0);

        foreach (var item in evenNumbers)
        {
            WriteLine($"eventNumber from numbers: {item}");
        }
    }

    //función anonima
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    //función lambda
    static Func<int, int> lambdaSquare = x => x * x;
}