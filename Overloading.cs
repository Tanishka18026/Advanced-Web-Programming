using System;

class Overloading
{
    public static void Main()
    {
        Console.WriteLine(volume(10));
        Console.WriteLine(volume(2.5F, 8));
        Console.WriteLine(volume(100L, 75, 15));
    }

  
    static int volume(int x)
    {
        return x * x * x;
    }


    static int volume(float r, int h)
    {

        return (int)(3.14519 * r * r * h);
    }


    static int volume(long l, int b, int h)
    {

        return (int)(l * b * h);
    }
}
