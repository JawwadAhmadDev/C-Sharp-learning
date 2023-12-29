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
