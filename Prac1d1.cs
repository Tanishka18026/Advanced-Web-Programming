class FibonacciGenerator
{
    public int GenerateFibonacci(int num)
    {
        if (num <= 0)
        {
            System.Console.WriteLine("Number must be positive.");
            return 0;
        }
        else if (num == 1)
        {
            System.Console.WriteLine("The Fibonacci Series of 1 term is: 0");
            return 1;
        }
        else
        {
            int a = 0, b = 1, c;
            System.Console.WriteLine("The Fibonacci Series of " + num + " terms is: ");
            System.Console.Write(a + ", " + b);

            for (int i = 2; i < num; i++)
            {
                c = a + b;
                System.Console.Write(", " + c);
                a = b;
                b = c;
            }

            return num;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        FibonacciGenerator fibonacciGenerator = new FibonacciGenerator();
        System.Console.Write("Enter the number of Fibonacci terms to generate: ");
        
        int num = System.Convert.ToInt32(System.Console.ReadLine());
        int result = fibonacciGenerator.GenerateFibonacci(num);
   //     System.Console.WriteLine("\nNumber of terms generated: " + result);
    }
}
