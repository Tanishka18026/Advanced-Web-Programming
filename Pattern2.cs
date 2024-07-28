class Pattern2
{
    static void Main()
    {
        int n = 5; // The number of rows
        
        for (int i = 1; i <= n; i++)
        {
            // Print leading spaces
            for (int j = n; j > i; j--)
            {
                System.Console.Write(" ");
            }
            
            // Print the numbers
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write(i + " ");
            }
            
            // Move to the next line
            System.Console.WriteLine();
        }
    }
}