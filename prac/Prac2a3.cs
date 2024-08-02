using System;

class QuadraticEquationSolver
{
    public void SolveQuadratic(double a, double b, double c)
    {
        // Calculate discriminant
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            // Two real roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Roots are real and distinct:");
            Console.WriteLine("Root 1 = " + root1);
            Console.WriteLine("Root 2 = " + root2);
        }
        else if (discriminant == 0)
        {
            // One real root (discriminant is zero)
            double root = -b / (2 * a);
            Console.WriteLine("Roots are real and equal:");
            Console.WriteLine("Root = " + root);
        }
        else
        {
            // Complex roots (discriminant is negative)
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Roots are complex:");
            Console.WriteLine("Root 1 = " + realPart + " + " + imaginaryPart + "i");
            Console.WriteLine("Root 2 = " + realPart + " - " + imaginaryPart + "i");
        }
    }
}

class Prac2a3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quadratic Equation Solver");
        Console.WriteLine("Enter the coefficients (a, b, c) for ax^2 + bx + c = 0:");

        // Read coefficients from user input
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        // Create an object of QuadraticEquationSolver
        QuadraticEquationSolver solver = new QuadraticEquationSolver();

        // Use the object to call the SolveQuadratic method
        solver.SolveQuadratic(a, b, c);
    }
}
