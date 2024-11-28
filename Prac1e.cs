// Class that contains the logic for mathematical operations
public class MathOperations
{
    // Method to add two numbers
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Method to subtract two numbers
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    // Method to multiply two numbers
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    // Method to divide two numbers
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            System.Console.WriteLine("Error: Division by zero is not allowed.");
            //return double.NaN; // Return Not a Number if division by zero
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations operations = new MathOperations();

        System.Console.Write("Enter the first number: ");
        double num1 = System.Convert.ToDouble(System.Console.ReadLine());

        System.Console.Write("Enter the second number: ");
        double num2 = System.Convert.ToDouble(System.Console.ReadLine());

        double sum = operations.Add(num1, num2);
        double difference = operations.Subtract(num1, num2);
        double product = operations.Multiply(num1, num2);
        double quotient = operations.Divide(num1, num2);

        System.Console.WriteLine("Sum: {0}", sum);
        System.Console.WriteLine("Difference: {0}", difference);
        System.Console.WriteLine("Product: {0}", product);
           }
}
