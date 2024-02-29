namespace vol5
{
    public class Program
    {
        public static void Main()
        {
            BankAccount account = new BankAccount (100, "123", 303, "him");
            account.Deposit(100);
            account.Withdraw(150);
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.FullAccountName);
        }
    }
}