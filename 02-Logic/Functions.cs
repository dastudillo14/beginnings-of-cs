

partial class Program
{

    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        if (number > 0)
            return "positivo";
        else if (number < 0)
            return "negativo";
        else
            return "zero";
    }

    static void Functions()
    {
        double area = CalculateArea(5.6, 2.3);
        WriteLine($"Area es {area}");

        int number = 0;
        string numberType = EvaluateNumber(number);
        WriteLine($"el número {number} es-> {numberType}");
    }
}