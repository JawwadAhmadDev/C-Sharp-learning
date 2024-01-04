// ===================== 1st Problem : Solution ====================== //
// Banking System (SavingsAccount Implementation):
public abstract class BankAccount
{
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
    public abstract decimal CalculateInterest();

    // Other common bank account properties and methods
}

public class SavingsAccount : BankAccount
{
    private decimal balance;

    public SavingsAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public override void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}, new balance: {balance}");
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}, new balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public override decimal CalculateInterest()
    {
        const decimal interestRate = 0.03M; // 3% interest rate
        return balance * interestRate;
    }
}
