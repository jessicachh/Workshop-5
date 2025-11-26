public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property: AccountNumber (GET only)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property: Balance (GET only, SET private)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Balance cannot be zero or negative.");
            }
        }
    }

    // Constructor (assign account number + initial balance)
    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Successfully deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be greater than 0.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than 0.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Successfully withdrawn: {amount}");
        }
    }
}