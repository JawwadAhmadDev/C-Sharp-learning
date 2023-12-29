/*
// ======================== 1st Problem: Solution ========================//
// Question Statement: Number Guessing Game

// generate random number between 1 and 100.
Random random = new Random();
int numberToGuess = random.Next(1, 10);

// take guess input from user.
int guess;
do
{
    Console.Write("Guess a number between 1 and 100: ");
    guess = Convert.ToInt32(Console.ReadLine());
} while (guess != numberToGuess);

Console.WriteLine("Correct! The number was " + numberToGuess);






// ======================== 2nd Problem: Solution ========================//
// Question Statement: Input Validation Loop

int inputNumber;

// repeat loop untill user enter positive number
do
{
    Console.Write("Enter a positive integer: ");
    inputNumber = Convert.ToInt32(Console.ReadLine());
} while (inputNumber <= 0);

Console.WriteLine("Valid number: " + inputNumber);





// ======================== 3rd Problem: Solution ========================//
// Question Statement: Reverse a Number

// take input from user
Console.WriteLine("Enter a number:");
int originalNumber = Convert.ToInt32(Console.ReadLine());

int reversedNumber = 0;

// reversing number.
do
{
    reversedNumber = reversedNumber * 10 + originalNumber % 10;
    originalNumber /= 10; // truncating last digit from the number.

} while (originalNumber > 0);


Console.WriteLine("Reversed number: " + reversedNumber);
*/






// ======================== 4th Problem: Solution ========================//
// Question Statement: Compute Compound Interest

char continueCalculation;

// repeat loop until user want to enter value
do
{
    // take inputs from user
    Console.Write("Enter principal: ");
    double principal = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter rate: ");
    double rate = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter time (in years): ");
    int time = Convert.ToInt32(Console.ReadLine());

    // calculating interest
    double amount = principal * Math.Pow(1 + rate / 100, time);

    // printing results
    Console.WriteLine("Compound interest: " + amount);

    // take input from user to continue or exit
    Console.WriteLine("Do another calculation? (y/n)");
    continueCalculation = Convert.ToChar(Console.ReadLine());

} while (continueCalculation == 'y');
