/*
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





// ===================== 2nd Problem: solution =================== //
// Problem Statement: Calculate the Sum of Odd Numbers in a Range

// taking input from user
Console.Write("Enter two numbers: ");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());

int sum = 0;

// calculating sum using for loop
for (int i = start; i <= end; i++)
{
    // check if the number is odd. if odd then add, skip otherwise.
    if (i % 2 != 0)
    {
        sum += i;
    }
}
Console.WriteLine("Sum of odd numbers from " + start + " to " + end + " : " + sum);
*/










// ===================== 3rd Problem: solution =================== //
// Problem Statement: Display the Multiplication Table Up to X

// taking input from user.
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the limit: ");
int limit = Convert.ToInt32(Console.ReadLine());

// printing table of number upto limit
for (int i = 1; i <= limit; i++)
{
    Console.WriteLine(number + " * " + i + " = " + (number * i));
}
