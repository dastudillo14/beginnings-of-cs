

partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit = 10)
    {
        WriteLine($"La tabla de multiplicar del número ${number} desde el 1  hasta el {tableLimit}\n");

        for (int i = 0; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }

        WriteLine();
    }

    static void PrintFactorialNumber(int number)
    {
        WriteLine($"Factorial del número {number} desde el 1 hasta el {number}\n");

        int current = 1;
        for (int i = 1; i <= number; i++)
        {
            current *= i; //->current = i * current
            WriteLine($"{i}! = {current}");
        }
    }
}