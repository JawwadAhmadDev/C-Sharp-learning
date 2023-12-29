
// ===================== 1st Problem: solution =================== //
// Problem Statement: Print a Pattern of Asterisks

// taking input from user.
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

// printing pattern
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

