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

// int num1 = 0, num2 = 0, temp = 0;

// // taking two numbers
// Console.WriteLine("Please Enter two numbers.");
// num1 = int.Parse(Console.ReadLine());
// num2 = int.Parse(Console.ReadLine());

// // arranging numbers
// if (num1 < num2)
// {
//     temp = num1;
//     num1 = num2;
//     num2 = temp;
// }

// // finding HCF / GCD
// while (num2 != 0)
// {
//     temp = num2;
//     num2 = num1 % num2;
//     num1 = temp;
// }

// Console.WriteLine("HCF / GCD: " + num1);










// ==================== Solution: 3rd Problem ===================== //
// Question Statement: Print Prime Numbers Up to N

// int num;

// // taking input from user
// Console.Write("Please enter a number greater than 2: ");
// num = int.Parse(Console.ReadLine());

// // starting point will be 2.
// int i = 2;


// Console.WriteLine("Prime numbers upto " + num + " are: ");

// // tranversing from 2 to given number.
// while (i <= num)
// {
//     // finding prime status of each number 
//     int j = 2;
//     bool isPrime = true;
//     while (j <= (i / 2))
//     {
//         if (i % j == 0)
//         {
//             isPrime = false;
//             break;
//         }
//         j++;
//     }

//     // printing if i is prime
//     if (isPrime)
//     {
//         Console.Write(i + "\t");
//     }

//     i++;
// }
// Console.WriteLine();









// ==================== Solution: 4th Problem ===================== //
// Question Statement: Generate a Fibonacci Sequence Up to N

int limit;
// taking input from user
Console.Write("Please enter a number: ");
limit = int.Parse(Console.ReadLine());



// printing fabonacci sequence
Console.WriteLine("Fabonacci sequence upto " + limit + " : ");

int first = 0, second = 1, next = 0;
while (next <= limit)
{
    Console.Write(next + "\t");
    first = second;
    second = next;
    next = first + second;
}

Console.WriteLine();