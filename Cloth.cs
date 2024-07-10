using System;
class Cloth
{
	public static void Main(string[] args)
	{

        int purchase_amount = System.Convert.ToInt32(args[0]);

        string clothtype = "handloom";
        double amount;

        if (purchase_amount <= 100)
        {
            if (clothtype == "mill")
            {
                amount=purchase_amount;
            }
            else if (clothtype == "handloom")
            {
                 amount=purchase_amount/(100*5);
            }
        }
        else if (purchase_amount > 100 && purchase_amount <= 200)
        {
            if (clothtype == "mill")
            {
                amount=purchase_amount/(100*5);
            }
            else if (clothtype == "handloom")
            {
                amount=purchase_amount/(100*7.5);
            }
        }
        else if (purchase_amount > 200 && purchase_amount <= 300)
        {
            if (clothtype == "mill")
            {
                amount=purchase_amount/(100*7.5);
            }
            else if (clothtype == "handloom")
            {
                amount=purchase_amount/(100*10);
            }
        }
        else if (purchase_amount > 300)
        {
            if (clothtype == "mill")
            {
                amount=purchase_amount/(100*10);
            }
            else if (clothtype == "handloom")
            {
                amount=purchase_amount/(100*15);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice"); 
        }

        Console.WriteLine("Amount to be paid " + amount);
    }
}
