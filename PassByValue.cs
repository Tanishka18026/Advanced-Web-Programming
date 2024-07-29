using System;

class PassByValue
{
    public static void Change(ref int m) 
    {
        m = m + 10;
    }

    public static void Main()
    {
        int x = 100;
        Change(ref x); 
        Console.WriteLine("x=" + x);
    }
}
