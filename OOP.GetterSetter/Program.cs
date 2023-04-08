
public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.SetAccNo("A_123");
        account.SetBalance(1000);
        Console.WriteLine(account.GetAccNo());
        Console.WriteLine(account.GetBalance());

    }
}