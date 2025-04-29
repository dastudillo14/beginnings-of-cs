partial class Program
{
    static void LoopGame()
    {
        int counter = 0;

        WriteLine("Pulse cualquier tecla para aumentar el contador...\n");

        WriteLine("Pulse ESC para salir \n");

        while (true)
        {
            var key = ReadKey(true).Key;

            if (key == ConsoleKey.Escape)
            {
                WriteLine($"Pulsaste {counter} teclas");
                WriteLine("Finalizó el juego. :D ");
                break;
            }
            else
            {
                counter++;
            }
        }

    }
}