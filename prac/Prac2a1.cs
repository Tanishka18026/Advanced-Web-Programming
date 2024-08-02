using System;

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


        Console.Write("Enter a number to find its factorial: ");
        int n = Convert.ToInt32(Console.ReadLine());


        int result = calculator.CalculateFactorial(n);


        Console.WriteLine("Factorial of {0} is {1}", n, result);
    }
}
