class QuadraticEquationSolver
{
    public void SolveQuadratic(double a, double b, double c)
    {
        // Calculate discriminant
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            // Two real roots
            double root1 = (-b + System.Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - System.Math.Sqrt(discriminant)) / (2 * a);
            System.Console.WriteLine("Roots are real and distinct:");
            System.Console.WriteLine("Root 1 = " + root1);
            System.Console.WriteLine("Root 2 = " + root2);
        }
        else if (discriminant == 0)
        {
            // One real root (discriminant is zero)
            double root = -b / (2 * a);
            System.Console.WriteLine("Roots are real and equal:");
            System.Console.WriteLine("Root = " + root);
        }
        else
        {
            // Complex roots (discriminant is negative)
            double realPart = -b / (2 * a);
            double imaginaryPart = System.Math.Sqrt(-discriminant) / (2 * a);
            System.Console.WriteLine("Roots are complex:");
            System.Console.WriteLine("Root 1 = " + realPart + " + " + imaginaryPart + "i");
            System.Console.WriteLine("Root 2 = " + realPart + " - " + imaginaryPart + "i");
        }
    }
}

class Prac2a3
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Quadratic Equation Solver");
        System.Console.WriteLine("Enter the coefficients (a, b, c) for ax^2 + bx + c = 0:");

        // Read coefficients from user input
        System.Console.Write("Enter a: ");
        double a = double.Parse(System.Console.ReadLine());

        System.Console.Write("Enter b: ");
        double b = double.Parse(System.Console.ReadLine());

        System.Console.Write("Enter c: ");
        double c = double.Parse(System.Console.ReadLine());

        // Create an object of QuadraticEquationSolver
        QuadraticEquationSolver solver = new QuadraticEquationSolver();

        // Use the object to call the SolveQuadratic method
        solver.SolveQuadratic(a, b, c);
    }
}
