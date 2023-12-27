// ==================== Solution: 1st Problem ===================== //
// Question Statement: Find the Smallest Divisor.

// int num, smallestDivisor;

// Console.Write("Please enter a positive number greater than 1 for which you want to find smallest divisor: ");
// num = Convert.ToInt32(Console.ReadLine());
// smallestDivisor = num;

// int i = 2;
// while (i < num)
// {
//     if (num % i == 0)
//     {
//         smallestDivisor = i;
//         break;
//     }
//     i++;
// }

// Console.WriteLine("Smallest Divisor of " + num + " is " + smallestDivisor);







// ==================== Solution: 2nd Problem ===================== //
// Question Statement: Compute the Greatest Common Divisor (GCD) or Highest Common factor (HCF)

int num1 = 0, num2 = 0, temp = 0;

// taking two numbers
Console.WriteLine("Please Enter two numbers.");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

// arranging numbers
if (num1 < num2)
{
    temp = num1;
    num1 = num2;
    num2 = temp;
}

// finding HCF / GCD
while (num2 != 0)
{
    temp = num2;
    num2 = num1 % num2;
    num1 = temp;
}

Console.WriteLine("HCF / GCD: " + num1);