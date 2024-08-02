using System;

class Function
{
    public int Demo(int num)
    {
        if (num <= 0)
        {
            Console.WriteLine("Number must be positive.");
            return 0;
        }
        if (num == 1)
        {
            Console.WriteLine("The Fibonacci Series of 1 term is: 0");
            return 1;
        }
        
        int a = 0, b = 1, c;
        Console.WriteLine("The Fibonacci Series of " + num + " terms is: ");
        Console.Write(a + ", " + b);

        for (int i = 2; i < num; i++)
        {
            c = a + b;
            Console.Write(", " + c);
            a = b;
            b = c;
        }
              
        return num; 
    }
}

class Prac1d1
{
    public static void Main(string[] args)
    {
        Function obj1 = new Function();
        Console.Write("Enter the number of Fibonacci terms to generate: ");
        
             int result = obj1.Demo(num);
            Console.WriteLine("Number of terms generated: " + result);
      
    }
}
