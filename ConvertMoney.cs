class ConvertMoney
{
    static void Main()
    {
        // Define the conversion rate from USD to INR
        const double conversionRate = 83.69; // Example rate, adjust as needed

        // Array to hold USD values
        double[] usdValues = new double[5];
        double[] inrValues = new double[5];

        // Loop to get 5 USD values from the user
        for (int i = 0; i < 5; i++)
        {
            System.Console.Write("Enter amount in USD (value " + (i + 1) + "): ");
            usdValues[i] = System.Convert.ToDouble(System.Console.ReadLine());
            
            // Convert to INR
            inrValues[i] = usdValues[i] * conversionRate;
        }

        // Print converted values
        System.Console.WriteLine("\nConverted values in INR:");
        for (int i = 0; i < 5; i++)
        {
            System.Console.WriteLine("USD " + usdValues[i] + " = INR " + inrValues[i].ToString("0.00"));
        }
    }
}