using System;
class ContinueBreak
{
    public static void Main()
    {
        int n = 10;
        while (n < 200)
        {
            if (n < 50)
            {
                Console.Write(" " + n);
                n = n + 10;
                continue;
            }

            if (n == 50)
            {
                Console.WriteLine( );
                n = n + 10;
                continue;
            }

            if (n > 90)
            {
                break;
            }

            Console.Write(" " + n);
            n = n + 10;
        }

        Console.WriteLine( );
    }
}
