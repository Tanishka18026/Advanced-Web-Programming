using System;

class CityGuide 
{
    public static void Main() {
        Console.WriteLine("Select your choice:");
        Console.WriteLine("1. London");
        Console.WriteLine("2. Bombay");
        Console.WriteLine("3. Paris");
        Console.WriteLine("Type your choice:");

        string choice = Console.ReadLine();

        switch (choice.ToLower()) {
            case "bombay":
                Console.WriteLine("Bombay: Guide 5");
                break;
            case "london":
                Console.WriteLine("London: Guide 10");
                break;
            case "paris":
                Console.WriteLine("Paris: Guide 15");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
