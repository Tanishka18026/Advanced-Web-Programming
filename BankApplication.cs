using System;
using System.Text.RegularExpressions;

public class BankApplication
{
    // Define a class for Bank Account
    class BankAccount
    {
        public string AccountHolderName { get; set; }
        public long AccountNumber { get; set; } // Changed to long
        public string AccountPassword { get; set; }
        public string AccountType { get; set; }
        public double AccountBalance { get; set; }
    }

    static BankAccount[] bankAccounts = new BankAccount[10]; // Array to store bank accounts
    static int accountCount = 0; // To keep track of number of accounts added

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Bank Management System");
            Console.WriteLine("1. Banker");
            Console.WriteLine("2. Customer");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    BankerMenu();
                    break;
                case 2:
                    CustomerMenu();
                    break;
                case 3:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void BankerMenu()
    {
        while (true)
        {
            Console.WriteLine("\nBanker Menu:");
            Console.WriteLine("1. Create Bank Account");
            Console.WriteLine("2. Display All Bank Accounts");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");
            
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateBankAccount();
                    break;
                case 2:
                    DisplayAllBankAccounts();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void CreateBankAccount()
    {
        Console.WriteLine("\nCreating Bank Account:");
        BankAccount account = new BankAccount();

        // Validate Account Holder Name
        Console.Write("Enter Account Holder Name: ");
        string accountHolderName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(accountHolderName) || Regex.IsMatch(accountHolderName, @"\d"))
        {
            Console.WriteLine("Invalid Account Holder Name. Name cannot be empty or contain numbers.");
            return;
        }
        account.AccountHolderName = accountHolderName;

        // Validate Account Number
        Console.Write("Enter Account Number (14 digits): ");
        string accountNumberInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(accountNumberInput) || !Regex.IsMatch(accountNumberInput, @"^\d{14}$"))
        {
            Console.WriteLine("Invalid Account Number. Account Number must be exactly 14 digits long.");
            return;
        }
        account.AccountNumber = long.Parse(accountNumberInput); // Changed to long

        // Validate Password
        Console.Write("Enter Account Password: ");
        string password = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(password))
        {
            Console.WriteLine("Invalid Password. Password cannot be empty.");
            return;
        }
        account.AccountPassword = password;

        // Validate Account Type
        Console.Write("Enter Account Type (current or savings): ");
        string accountType = Console.ReadLine().ToLower();
        if (accountType != "current" && accountType != "savings")
        {
            Console.WriteLine("Invalid Account Type. Account Type must be either 'current' or 'savings'.");
            return;
        }
        account.AccountType = accountType;

        bankAccounts[accountCount++] = account; // Add account to the array
        Console.WriteLine("Bank Account created successfully.");
    }

    // Method to display all bank accounts
    static void DisplayAllBankAccounts()
    {
        Console.WriteLine("\nAll Bank Accounts:");
        if (accountCount == 0)
        {
            Console.WriteLine("No accounts found.");
            return;
        }

        for (int i = 0; i < accountCount; i++)
        {
            Console.WriteLine("Account Holder Name: {0}, Account Number: {1}, Account Type: {2}", bankAccounts[i].AccountHolderName, bankAccounts[i].AccountNumber, bankAccounts[i].AccountType);
        }
    }

    // Method to handle Customer menu
    static void CustomerMenu()
    {
        Console.WriteLine("\nCustomer Login:");
        Console.Write("Enter Account Number: ");
        long accountNumber = long.Parse(Console.ReadLine()); // Changed to long
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        // Check if account exists
        BankAccount account = FindBankAccount(accountNumber, password);
        if (account == null)
        {
            Console.WriteLine("Invalid Account Number or Password.");
            return;
        }

        // Customer operations menu
        while (true)
        {
            Console.WriteLine("\nWelcome, {0}!", account.AccountHolderName);
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to withdraw: ");
                    double amountWithdraw = double.Parse(Console.ReadLine());
                    if (amountWithdraw > account.AccountBalance)
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                    else
                    {
                        account.AccountBalance -= amountWithdraw;
                        Console.WriteLine("Amount {0} withdrawn successfully.", amountWithdraw);
                    }
                    break;
                case 2:
                    Console.Write("Enter amount to deposit: ");
                    double amountDeposit = double.Parse(Console.ReadLine());
                    account.AccountBalance += amountDeposit;
                    Console.WriteLine("Amount {0} deposited successfully.", amountDeposit);
                    break;
                case 3:
                    Console.WriteLine("Your current balance is: {0}", account.AccountBalance);
                    break;
                case 4:
                    Console.WriteLine("Exiting customer menu.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    // Method to find a bank account by account number and password
    static BankAccount FindBankAccount(long accountNumber, string password) // Changed to long
    {
        foreach (var account in bankAccounts)
        {
            if (account != null && account.AccountNumber == accountNumber && account.AccountPassword == password)
            {
                return account;
            }
        }
        return null;
    }
}