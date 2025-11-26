class Program
{
    static void Main(string[] args)
    {
        // Create an object of BankAccount
        BankAccount account = new BankAccount("ACC12345", 1000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);

        // Deposit money
        account.Deposit(500);

        // Withdraw money
        account.Withdraw(300);

        // Display remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);

        Console.ReadLine();
    }
}