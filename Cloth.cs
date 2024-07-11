using System;

class Cloth
{
    public static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Please provide purchase amount and cloth type.");
            return;
        }

        int purchase_amount = Convert.ToInt32(args[0]);
        string clothtype = args[1].ToLower();
        double amount = 0; // Initialize the variable

        if (purchase_amount <= 100)
        {
            if (clothtype == "mill")
            {
                amount = purchase_amount;
            }
            else if (clothtype == "handloom")
            {
                amount = purchase_amount*(1 - 0.05);
            }
            else
            {
                Console.WriteLine("Invalid cloth type");
                return;
            }
        }
        else if (purchase_amount <= 200)
        {
            if (clothtype == "mill")
            {
                amount = purchase_amount*(1 - 0.05);
            }
            else if (clothtype == "handloom")
            {
                amount = purchase_amount*(1 - 0.075);
            }
            else
            {
                Console.WriteLine("Invalid cloth type");
                return;
            }
        }
        else if (purchase_amount <= 300)
        {
            if (clothtype == "mill")
            {
                amount = purchase_amount*(1 - 0.075);
            }
            else if (clothtype == "handloom")
            {
                amount = purchase_amount*(1 - 0.10);
            }
            else
            {
                Console.WriteLine("Invalid cloth type");
                return;
            }
        }
        else if (purchase_amount > 300)
        {
            if (clothtype == "mill")
            {
                amount = purchase_amount*(1 - 0.10);
            }
            else if (clothtype == "handloom")
            {
                amount = purchase_amount*(1 - 0.15);
            }
            else
            {
                Console.WriteLine("Invalid cloth type");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid choice");
            return; // Exit the program if invalid choice
        }

        Console.WriteLine("Amount to be paid: " + amount);
    }
}
