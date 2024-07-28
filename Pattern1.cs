class Pattern1
{
    static void Main()
    {
        int n = 5; // The number of rows

        for (int i = 1; i <= n; i++)
        {
            // Print the numbers
            for (int j = 1; j <= i; j++)
            {
                System.Console.Write(i + " ");
            }

            // Move to the next line
            System.Console.WriteLine();
        }
    }
}