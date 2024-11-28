class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the FloydsTriangleGenerator class
        FloydsTriangleGenerator triangleGenerator = new FloydsTriangleGenerator();

        // Prompt the user for the number of rows
        System.Console.Write("Enter the number of rows for Floyd's Triangle: ");
        int rows = System.Convert.ToInt32(System.Console.ReadLine());

        // Generate and print Floyd's Triangle directly
        triangleGenerator.GenerateFloydsTriangle(rows);
    }
}

class FloydsTriangleGenerator
{
    public void GenerateFloydsTriangle(int rows)
    {
        int number = 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                System.Console.Write(number + " ");
                number++;
            }
            System.Console.WriteLine();  // Moves to the next line
        }
    }
}
