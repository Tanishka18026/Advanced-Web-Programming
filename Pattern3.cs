class Pattern3
{
    static void Main()
    {
        int n = 5; // The number of rows
        
        for (int i = n; i >= 1; i--)
        {
            // Print leading spaces
            for (int j = n; j > i; j--)
            {
                System.Console.Write(" ");
            }
            
            // Print the $ symbols
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write("$ ");
            }
            
            // Move to the next line
            System.Console.WriteLine();
        }
    }
}