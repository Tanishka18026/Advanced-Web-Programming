using System;

class Method
{

    public int Cube(int x)
    {
        return x * x * x;
    }
}

class MethodTest
{
    public static void Main()
    {

        Method M = new Method();


        int y = M.Cube(5);


        Console.WriteLine(y);
    }
}
