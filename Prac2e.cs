class Program
{
    // Delegate declaration
    public delegate int Operation(int x, int y);

    // Method for addition
    public int Add(int x, int y)
    {
        return x + y;
    }

    // Method for subtraction
    public int Subtract(int x, int y)
    {
        return x - y;
    }
}

class main
{
    static void Main()
    {
        // Create an instance of the Program class
        Program program = new Program();

        // Get user input for the two numbers
        System.Console.Write("Enter the first number: ");
        int num1 = System.Convert.ToInt32(System.Console.ReadLine());

        System.Console.Write("Enter the second number: ");
        int num2 = System.Convert.ToInt32(System.Console.ReadLine());

        // Create delegate instances
        Program.Operation addOperation = program.Add;
        Program.Operation subtractOperation = program.Subtract;

        // Perform addition
        int resultAdd = addOperation(num1, num2);
        System.Console.WriteLine("Addition: {0}", resultAdd);

        // Perform subtraction
        int resultSubtract = subtractOperation(num1, num2);
        System.Console.WriteLine("Subtraction: {0}", resultSubtract);
    }
}
