using System;

class SimpleATM
{
    static void Main()
    {
        Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====\n");

        // Ask for user name
        Console.Write("HI , WHAT IS YOUR NAME?\n");
        string name = Console.ReadLine();

        Console.WriteLine($"\nWELCOME {name.ToUpper()}!");

        // Input and validation for account balance
        decimal balance;
        while (true)
        {
            Console.Write("Enter account balance: ");
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out balance) && balance >= 0)
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid numeric balance.");
        }

        // Input and validation for withdrawal amount
        decimal withdrawal;
        while (true)
        {
            Console.Write("Enter withdrawal amount: ");
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out withdrawal) && withdrawal > 0)
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid numeric withdrawal amount.");
        }

        // Perform transaction
        if (withdrawal <= balance)
        {
            balance -= withdrawal;
            Console.WriteLine("\nWithdrawal successful!");
            Console.WriteLine($"Updated Balance: {balance:F2}");
        }
        else
        {
            Console.WriteLine("\nWithdrawal failed! Insufficient funds.");
        }

        // Display transaction time
        Console.WriteLine($"Transaction Time: {DateTime.Now}");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
