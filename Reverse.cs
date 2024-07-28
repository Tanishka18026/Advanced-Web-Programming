class Reverse
{
    public static void Main(string[] args)
    {
        System.Console.Write("Enter a number: ");
        int number = System.Convert.ToInt32(System.Console.ReadLine());

        int reversedNumber = 0;

        while (number > 0)
        {
            int remainder = number % 10; 
            reversedNumber = reversedNumber * 10 + remainder; 
            number = number / 10; 
        }

        System.Console.WriteLine("Reversed number: {0}",reversedNumber);

	System.Console.ReadLine();
    }
}
