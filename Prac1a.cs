/*Create an application that obtains four int values from the user and displays the product.*/
/*Console*/
namespace Tanijen
{
    class Prac1a
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter four integer values:");

            System.Console.Write("Value 1: ");
            int value1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Value 2: ");
            int value2 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Value 3: ");
            int value3 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Value 4: ");
            int value4 = int.Parse(System.Console.ReadLine());

            int product = value1 * value2 * value3 * value4;

            System.Console.WriteLine("The product of " + value1 + ", " + value2 + ", " + value3 + ", and " + value4 + " is: " + product);

            System.Console.ReadKey();
        }
    }
}
