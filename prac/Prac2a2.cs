using System;

namespace CurrencyConverter
{
    public class ConversionService
    {
        private const double ConversionRate = 74.50; 

        public double ConvertUsdToInr(double usdValue)
        {
            return usdValue * ConversionRate;
        }
    }

    public class Prac2a2
    {
        public static void Main()
        {
            ConversionService conversionService = new ConversionService();
            Console.Write("Enter amount in USD: ");
            
                           double inrValue = conversionService.ConvertUsdToInr(usdValue);
                Console.WriteLine("USD {0} = INR {1:0.00}", usdValue, inrValue);
        }
    }
}
