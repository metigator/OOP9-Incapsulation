
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        account.AccNo = "A_123";
        account.Balance = 1000;

        account.Withdraw(500);

        account.Balance -= 1400;

        account.Deposit(100);
    }
}