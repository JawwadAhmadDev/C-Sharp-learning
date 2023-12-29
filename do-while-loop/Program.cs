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
*/





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
