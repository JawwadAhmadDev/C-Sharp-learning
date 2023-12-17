// ================= Solution: 1st Problem ================== //
// Tiered Tax Calculation Based on Income and Filing Status

// variable declarations
double income, tax;
bool married;


// taking inputs from user.
Console.log("Please enter your income: ");
income = double.parse(Console.ReadLine());

Console.log("Please enter your married status(0 for unmarried / 1 for married): ");
married = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (married)
{
    if (income <= 40000)
    {
        tax = income * 0.2;
    }
    else if (income <= 85000)
    {
        tax = 4000 + (income - 40000) * 0.4;
    }
    else
    {
        tax = 13000 + (income - 85000) * 0.6;
    }
}
else
{
    if (income <= 40000)
    {
        tax = income * 0.1;
    }
    else if (income <= 85000)
    {
        tax = 4000 + (income - 40000) * 0.2;
    }
    else
    {
        tax = 13000 + (income - 85000) * 0.3;
    }
}

Console.WriteLine($"\nYour Income: {income}\nMarried Status: {married}\nTax amount: ${tax}");
