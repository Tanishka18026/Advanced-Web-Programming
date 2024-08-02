using System;

public class NumberProcessor
{
    public int ReverseNumber(int number)
    {
        int reversedNum=0, sumOfDigits=0;

		while(num!=0)
		{
			int digit=num%10;
			reversedNum=reversedNum*10+digit;
			sumOfDigits +=digit;
			num/=10;
		}

          return (reversedNum, sumOfDigits);
    }

}

public class Prac1d5
{
    public static void Main(string[] args)
    {
        NumberProcessor processor = new NumberProcessor();

        Console.Write("Enter a number: ");
                   int reversedNum = processor.ReverseNumber(num);
            int sumOfDigits = processor.SumOfDigits(num);

            Console.WriteLine("Reversed number: {0}", reversedNum);
            Console.WriteLine("Sum of Digits: {0}", sumOfDigits);
            }
}
