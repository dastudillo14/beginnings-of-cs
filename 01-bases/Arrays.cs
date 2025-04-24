
partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        int[] numbersArray = [1, 2, 3, 4, 5, 6, 7];

        Console.WriteLine(numbers[0]);
        Console.WriteLine(numbersArray[2]);

        int length = numbersArray.Length;

        Console.WriteLine($"Longitud de numbersArray es {length}");
        Console.WriteLine($"Último de numbersArray es {numbersArray[length - 1]}");

        //Rangos para obtner subarreglos
        int[] firstThree = numbersArray[..3];
        foreach (var item in firstThree)
        {
            Console.WriteLine($"firstThree es {item}");
        }

        int[] fromIndexTwo = numbersArray[2..];
        foreach (var item in fromIndexTwo)
        {
            Console.WriteLine($"fromIndexTwo es {item}");
        }

        Console.WriteLine($"fromIndexTwo es {fromIndexTwo}");




    }
}