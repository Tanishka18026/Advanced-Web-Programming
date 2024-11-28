class TemperatureConverter
{
    private float _celsius;
    private float _fahrenheit;

    // Convert Celsius to Fahrenheit
    public float CelsiusToFahrenheit(float celsius)
    {
        _celsius = celsius;
        _fahrenheit = (_celsius * 9.0f / 5.0f) + 32.0f;
        return _fahrenheit;
   }

    // Convert Fahrenheit to Celsius
    public float FahrenheitToCelsius(float fahrenheit)
    {
        _fahrenheit = fahrenheit;
        _celsius = (_fahrenheit - 32) * (5.0f / 9.0f);
        return _celsius;
    }
}

class Program12
{
    static void Main()
    {
        TemperatureConverter converter = new TemperatureConverter();

        System.Console.WriteLine("Enter the type of conversion (c for Celsius to Fahrenheit, f for Fahrenheit to Celsius):");
        char conversionType = System.Console.ReadKey().KeyChar;
        System.Console.WriteLine(); // Move to the next line

        if (conversionType == 'c')  
        {
            System.Console.Write("Enter temperature in Celsius: ");
            float celsius = float.Parse(System.Console.ReadLine());
            float fahrenheit = converter.CelsiusToFahrenheit(celsius);
            System.Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
        else if (conversionType == 'f')
        {
            System.Console.Write("Enter temperature in Fahrenheit: ");
            float fahrenheit = float.Parse(System.Console.ReadLine());
            float celsius = converter.FahrenheitToCelsius(fahrenheit);
            System.Console.WriteLine("Temperature in Celsius: " + celsius);
        }
        else
        {
            System.Console.WriteLine("Invalid option. Please restart the program and enter 'c' or 'f'.");
        }
    }
}
