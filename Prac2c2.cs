// Define the Calculator class
class Calculator
{
    public int Divide(int dividend, int divisor)
    {
                return dividend / divisor;
    }
}

// Define the Program class
class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        try
        {
            // Get user input for dividend
            System.Console.WriteLine("Enter the dividend:");
            string dividendInput = System.Console.ReadLine();
            int dividend = System.Convert.ToInt32(dividendInput);

            // Get user input for divisor
            System.Console.WriteLine("Enter the divisor:");
            string divisorInput = System.Console.ReadLine();
            int divisor = System.Convert.ToInt32(divisorInput);

            // Perform division
            int result = calculator.Divide(dividend, divisor);
            System.Console.WriteLine("Result: " + result);
        }
        catch (System.DivideByZeroException ex)
        {
            // Handling divide-by-zero exception
            System.Console.WriteLine("Error: " + ex.Message);
        }
        catch (System.FormatException ex)
        {
            // Handling format exception (e.g., when input is not a valid number)
            System.Console.WriteLine("Error: Invalid input format. " + ex.Message);
        }
        catch (System.Exception ex)
        {
            // Handling any other exceptions
            System.Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            // Code that runs regardless of whether an exception occurred or not
            System.Console.WriteLine("Operation completed.");
        }
    }
}
