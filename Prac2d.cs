/*using System;

class BoxUnboxExample
{
    static void Main()
    {
        // Prompt user for input
        Console.Write("Enter an integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Boxing: Converting value type to reference type
        object obj = num; // Here, `num` is boxed into `obj`

        // Unboxing: Converting reference type back to value type
        int unboxedNum = (int)obj; // Here, `obj` is unboxed back to `int`

        // Display results
        Console.WriteLine("Original value (int): " + num);
        Console.WriteLine("Boxed value (object): " + obj);
        Console.WriteLine("Unboxed value (int): " + unboxedNum);
    }
}*/

// Class that contains the boxing and unboxing logic
class BoxUnboxOperations
{
    public static object Box(int value)
    {
        return value; // Boxing the integer value into an object
    }

    public static int Unbox(object obj)
    {
        return (int)obj; // Unboxing the object back to an integer
    }
}

// Main class containing the entry point of the program
class Program
{
    static void Main()
    {
        // Prompt user for input
        System.Console.Write("Enter an integer: ");
        int num = System.Convert.ToInt32(System.Console.ReadLine());

        // Use BoxUnboxOperations class to box and unbox the value
        object boxedValue = BoxUnboxOperations.Box(num);
        int unboxedValue = BoxUnboxOperations.Unbox(boxedValue);

        // Display results
        System.Console.WriteLine("Original value (int): " + num);
        System.Console.WriteLine("Boxed value (object): " + boxedValue);
        System.Console.WriteLine("Unboxed value (int): " + unboxedValue);
    }
}

