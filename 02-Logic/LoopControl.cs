
partial class Program
{
    static void LoopControl()
    {
        //break
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                break;
            }
            WriteLine($"break-> {i}");
        }

        //continue
        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7)
            {
                continue;
            }
            WriteLine($"continue-> {i}");
        }

        //return
         for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                //return;
            }
            WriteLine($"return-> {i}");
        }

        //bucle infinito
        //while (true)
        //{
        //    WriteLine("Bucle infinito...");
        //}

        //for(; ;){
        //    WriteLine("Bucle infinito...");
        //}


    }
}