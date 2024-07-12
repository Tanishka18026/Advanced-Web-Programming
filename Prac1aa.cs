/*Create an application that obtains four int values from the user and displays the product.*/
/*Command line argument*/
class Prac1aa
{
    static void Main(string[] args)
    {
        int value1 = int.Parse(args[0]);
        int value2 = int.Parse(args[1]);
        int value3 = int.Parse(args[2]);
        int value4 = int.Parse(args[3]);

        int product = value1 * value2 * value3 * value4;

        System.Console.WriteLine("The product of " + value1 + ", " + value2 + ", " + value3 + ", and " + value4 + " is: " + product);
    }
}
