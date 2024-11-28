class Calculator
{
    public int CalculateProduct(int value1, int value2, int value3, int value4)
    {
        return value1 * value2 * value3 * value4;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter four integer values:");

        System.Console.Write("Value 1: ");
        int value1 = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Value 2: ");
        int value2 =System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Value 3: ");
        int value3 = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Value 4: ");
        int value4 = System.Convert.ToInt32(System.Console.ReadLine());

        // Create an instance of Calculator
        Calculator calculator = new Calculator();
        
        // Use the Calculator object to calculate the product
        int product = calculator.CalculateProduct(value1, value2, value3, value4);

        // Print the result
        System.Console.WriteLine("The product of " + value1 + ", " + value2 + ", " + value3 + ", and " + value4 + " is: " + product);
    }
}
