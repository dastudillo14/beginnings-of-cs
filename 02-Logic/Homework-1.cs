
partial class Program
{
    static void FizzBuzzHomework()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                WriteLine($"FizzBuzz-> {i}");
            }
            else if (i % 3 == 0)
            {
                WriteLine($"Fizz-> {i}");
            }
            else if (i % 5 == 0)
            {
                WriteLine($"Buzz-> {i}");
            }
            else
            {
                WriteLine($"Number-> {i}");
            }
        }
    }
}