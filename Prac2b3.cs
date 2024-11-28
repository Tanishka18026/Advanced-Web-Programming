class ADD
{
    int x, y;
    double f;
    string s;

    public ADD(int a, double b)
    {
        x = a;
        f = b;
    }

    public ADD(int a, string b)
    {
        y = a;
        s = b;
    }

    public void show()
    {
        System.Console.WriteLine("1st constructor (int + float): {0}", (x + f));
    }

    public void show1()
    {
        System.Console.WriteLine("2nd constructor (int + string): {0}", (y + s));
    }
}

class Prac2b3 
{
    public static void Main()
    {
        System.Console.WriteLine("Enter an integer:");
        int inputInt =  System.Convert.ToInt32( System.Console.ReadLine());

        System.Console.WriteLine("Enter a floating-point number:");
        double inputDouble =  System.Convert.ToDouble( System.Console.ReadLine());

        ADD g = new ADD(inputInt, inputDouble);
        g.show();

        System.Console.WriteLine("\nEnter another integer:");
        int anotherInt =  System.Convert.ToInt32( System.Console.ReadLine());

        System.Console.WriteLine("Enter a string:");
        string inputString =  System.Console.ReadLine();

        ADD q = new ADD(anotherInt, inputString);
        q.show1();
    }
}
