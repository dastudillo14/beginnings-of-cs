
partial class Program
{
    static void HandleException()
    {
        int number = 10;
        string? amount = "";
        try
        {
            //int result = number / 0;
            WriteLine("Ingrese un monto");
            amount = ReadLine();

            if (string.IsNullOrEmpty(amount)) return;


            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"monto ingresado es: {amountValue}");
            }
            else
            {
                WriteLine("no se pudo convertir el texto a número");
            }

            ValidateAge(16);


        }
        catch (DivideByZeroException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"Error dividebyzero {e}");
        }
        catch (FormatException e) when (amount.Contains('$'))
        {
            WriteLine("no es necesario usar el simbolo de $");
        }
        catch (Exception e)
        {
            WriteLine($"Exception-> {e.Message}");
        }
        finally
        {
            WriteLine("Finalizó.");
        }



        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new ArgumentException("La edad debe ser mayor a 18");
            }
        }

    }
}