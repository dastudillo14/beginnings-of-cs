partial class Program
{
    static void Converstion()
    {
        //Conversión implícita
        int number = 10;
        double doubleNumber = number;
        WriteLine($"number-> {number} - doubleNumber-> {doubleNumber}");

        //Conversión explícita
        double exNumber = 42.5;
        int intNumber = (int)exNumber;
        WriteLine($"exNumber-> {exNumber} - intNumber-> {intNumber}");

        //No relacionados usando
        //Parse
        string text = "1123";
        int textNumber = int.Parse(text);
        WriteLine($"text-> {text}  textNumber-> {textNumber}");

        //Convert
        double decimalNumber = 48.2;
        int newIntNumber = Convert.ToInt32(decimalNumber); //Redondea
        WriteLine($"decimalNumber-> {decimalNumber}  newIntNumber-> {newIntNumber}");

    }
}