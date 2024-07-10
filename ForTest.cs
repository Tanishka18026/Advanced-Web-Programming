using System;
class ForTest
{
    public static void Main()
    {
        long p;
        int n;
        double q;
        Console.WriteLine("2 to power -n    n     2 to power n");

        p = 1L;
        for (n = 0; n < 10; ++n)
        {
            if (n == 0)
            {
                p = 1L;
            }
            else
            {
                p = p * 2;
            }
            
            q = 1.0 / (double)p;
            
            Console.WriteLine("{0,-15} {1,-5} {2,-15}", q, n, p);
        }
    }
}
