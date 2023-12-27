// ==================== Solution: 1st Problem ===================== //
// Question Statement: Find the Smallest Divisor.

int num, smallestDivisor;

Console.Write("Please enter a positive number greater than 1 for which you want to find smallest divisor: ");
num = Convert.ToInt32(Console.ReadLine());
smallestDivisor = num;

int i = 2;
while (i < num)
{
    if (num % i == 0)
    {
        smallestDivisor = i;
        break;
    }
    i++;
}

Console.WriteLine("Smallest Divisor of " + num + " is " + smallestDivisor);