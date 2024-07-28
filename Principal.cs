class Principal
{
    public static void Main()
    {
        double[] finalAmounts = { 1000, 2000, 3000, 4000, 5000, 6000, 7000, 8000, 9000, 10000 };
        double[] interestRates = { 0.10, 0.11, 0.12, 0.13, 0.14, 0.15, 0.16, 0.17, 0.18, 0.19, 0.20 };
        int years = 5; // Number of years

        System.Console.WriteLine("{0,-15} {1,-10} {2,-10}", "Final Amount", "Rate", "Principal");

        for (int i = 0; i < finalAmounts.Length; i++)
        {
            double v = finalAmounts[i];

            for (int j = 0; j < interestRates.Length; j++)
            {
                double r = interestRates[j];

                double p = v / System.Math.Pow(1 + r, years);

                System.Console.WriteLine("{0,-15:C} {1,-10:P2} {2,-10:C}", v, r, p);
            }
        }
    }
}
