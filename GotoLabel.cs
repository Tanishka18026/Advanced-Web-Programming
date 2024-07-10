using System;
class GotoLabel
{
    public static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            Console.WriteLine(" ");
            if (i >= 10)
                break;
            
            for (int j = 1; j < 100; j++)
            {
                Console.Write(" * ");
                if (j == i)
                    goto loop1;
            }
            
            loop1: continue;
        }

        Console.WriteLine("Termination by BREAK");
    }
}
