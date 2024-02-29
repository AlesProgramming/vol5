namespace vol5;

internal class BankAccount 
{
    private int balance;
    private string accountNumber;
    private int bankCode;
    
    public string Owner { get; set; }

    public BankAccount (int balance, string accountNumber, int bankCode, string owner)
    {
        this.balance = balance;
        this.accountNumber = accountNumber;
        this.bankCode = bankCode;
        this.Owner = owner;
    }

    public void Deposit(int amount)
    {
        balance += amount;
    }

    public void Withdraw(int amount)
    {
        if (balance - amount >= 0)
        {
            balance -= amount;
        }
    }

    public int Balance
    {
        get { return balance; }
    }
}