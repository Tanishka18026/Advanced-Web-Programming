using System;

class Calculator
{
    public int CalculateProduct(int value1, int value2, int value3, int value4)
    {
        return value1 * value2 * value3 * value4;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter four integer values:");

        Console.Write("Value 1: ");
        int value1 = int.Parse(Console.ReadLine());

        Console.Write("Value 2: ");
        int value2 = int.Parse(Console.ReadLine());

        Console.Write("Value 3: ");
        int value3 = int.Parse(Console.ReadLine());

        Console.Write("Value 4: ");
        int value4 = int.Parse(Console.ReadLine());

        // Create an instance of Calculator
        Calculator calculator = new Calculator();
        
        // Use the Calculator object to calculate the product
        int product = calculator.CalculateProduct(value1, value2, value3, value4);

        // Print the result
        Console.WriteLine("The product of " + value1 + ", " + value2 + ", " + value3 + ", and " + value4 + " is: " + product);
    }
}
