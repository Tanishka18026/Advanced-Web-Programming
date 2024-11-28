class FactorialCalculator
{
    public int CalculateFactorial(int n) 
    { 
        if (n == 0) 
            return 1; 
        return n * CalculateFactorial(n - 1);
    }
}

class Prac2a1
{
    public static void Main() 
    { 
        FactorialCalculator calculator = new FactorialCalculator();

        System.Console.Write("Enter a number to find its factorial: ");
        int n = System.Convert.ToInt32(System.Console.ReadLine());

        int result = calculator.CalculateFactorial(n);

        System.Console.WriteLine("Factorial of {0} is {1}", n, result);
    }
}
