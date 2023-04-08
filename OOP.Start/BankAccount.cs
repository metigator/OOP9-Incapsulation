
public class BankAccount
{
    public const decimal MaxWithdrawable = 1000;

    public string AccNo;
    public decimal Balance;

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Log($"REJECTED: Deposit NEGATIVE {amount.ToString("C")}");
            return;
        }

        Balance += amount;
        Log($"ACCEPTED:  {amount.ToString("C")} deposited");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > MaxWithdrawable)
        {
            Log($"REJECTED: MAX WITHDRAWABLE {amount.ToString("C")} > {MaxWithdrawable.ToString("C")}");
            return;
        }
        if (amount > Balance)
        {
            Log($"REJECTED: INSUFFICIENT BALANCE {amount.ToString("C")} > {Balance.ToString("C")}");
            return;
        }

        Balance -= amount;

        Log($"ACCEPTED:  {amount.ToString("C")} withdrawed");
    }

    private void Log(string message)
    {
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        Console.WriteLine($"[{timestamp}] {message}");
        Console.WriteLine($"[{timestamp}] Balance Info: Account No: '{AccNo}', Balance:'{Balance.ToString("C")}'");
    }

}
