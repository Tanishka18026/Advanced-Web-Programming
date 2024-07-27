using System;

class func
{
	public void Calculate()
	{
		Console.WriteLine("Select your choice");
        Console.WriteLine("London");
        Console.WriteLine("Bombay");
        Console.WriteLine("Paris");
        Console.WriteLine("Type your choice");

        string name = Console.ReadLine();

        switch (name)
        {
            case "Bombay":
                Console.WriteLine("Bombay: Guide 5");
                break;
            case "London":
                Console.WriteLine("London: Guide 10");
                break;
            case "Paris":
                Console.WriteLine("Paris: Guide 15");
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
	}
	}
}

class CityGuide
{
    public static void Main()
    {
        func obj=new func();
	obj.Calculate();
        
    }
}



