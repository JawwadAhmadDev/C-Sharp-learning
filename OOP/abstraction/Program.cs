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












// ===================== 4th Problem : Solution ====================== //
// Vehicle Control System:
public abstract class Vehicle
{
    public abstract void StartEngine();
    public abstract void StopEngine();
    public abstract void Accelerate();
    public abstract void Brake();
}


public class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped");
    }

    public override void Accelerate()
    {
        Console.WriteLine("Car is accelerating");
    }

    public override void Brake()
    {
        Console.WriteLine("Car brakes applied");
    }
}















// ===================== 5th Problem : Solution ====================== //
// Smart Device Interface (SmartPhone Implementation):
public abstract class SmartDevice
{
    public abstract void TurnOn();
    public abstract void TurnOff();
    public abstract void UpdateFirmware();
}



public class SmartPhone : SmartDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("SmartPhone is now on");
    }

    public override void TurnOff()
    {
        Console.WriteLine("SmartPhone is now off");
    }

    public override void UpdateFirmware()
    {
        Console.WriteLine("Updating SmartPhone firmware...");
        // Firmware update logic here
    }
}
