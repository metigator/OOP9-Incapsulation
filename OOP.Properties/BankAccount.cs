
public class BankAccount
{
    private const decimal _MaxWithdrawable = 1000;

    private string _accNo;
    private decimal _balance;

    public string AccNo
    {
        get
        {
            return _accNo;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                Log("INVALID ACCOUNT NO");
            }
        }
    }

    //public decimal Balance
    //{
    //    get
    //    {
    //        return _balance;
    //    }
    //}

    public decimal Balance => _balance;


    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Log($"REJECTED: Deposit NEGATIVE {amount.ToString("C")}");
            return;
        }

        _balance += amount;
        Log($"ACCEPTED:  {amount.ToString("C")} deposited");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > _MaxWithdrawable)
        {
            Log($"REJECTED: MAX WITHDRAWABLE {amount.ToString("C")} > {_MaxWithdrawable.ToString("C")}");
            return;
        }
        if (amount > _balance)
        {
            Log($"REJECTED: INSUFFICIENT BALANCE {amount.ToString("C")} > {_balance.ToString("C")}");
            return;
        }

        _balance -= amount;

        Log($"ACCEPTED:  {amount.ToString("C")} withdrawed");
    }

    private void Log(string message)
    {
        var timestamp = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        Console.WriteLine($"[{timestamp}] {message}");
        Console.WriteLine($"[{timestamp}] Balance Info: Account No: '{_accNo}', Balance:'{_balance.ToString("C")}'");
    }

}
