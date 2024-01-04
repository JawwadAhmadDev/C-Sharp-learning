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









// ===================== 2nd Problem : Solution ====================== //
// Shapes Drawing Application (Circle Implementation):

public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    private int radius;

    public Circle(int radius)
    {
        this.radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle with radius {radius}");
        // Additional drawing logic here
    }
}











// ===================== 3rd Problem : Solution ====================== //
// Employee Management System (FullTimeEmployee Implementation):

public abstract class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public abstract decimal CalculateSalary();
}


public class FullTimeEmployee : Employee
{
    public decimal Salary { get; set; }

    public FullTimeEmployee(string name, int id, decimal salary)
    {
        Name = name;
        ID = id;
        Salary = salary;
    }

    public override decimal CalculateSalary()
    {
        // Assuming Salary is annual for a full-time employee
        return Salary / 12; // Monthly salary
    }
}

