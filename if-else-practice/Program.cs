// ===================== Solution: 1st Problem ======================//

// bool hasBoardingPass, securityPassed;
// double luggageWeight;

// // taking inputs from user
// Console.Write("Have you a boarding pass? (0 for false / 1 for true): ");
// hasBoardingPass = int.Parse(Console.ReadLine()) == 0 ? false : true;

// Console.Write("Please enter you luggage weight: ");
// luggageWeight = double.Parse(Console.ReadLine());

// Console.Write("Are you security passed? (0 for false / 1 for true): ");
// securityPassed = int.Parse(Console.ReadLine()) == 0 ? false : true;


// // applying conditions
// if (hasBoardingPass && luggageWeight < 20 && securityPassed)
// {
//     Console.WriteLine("Boarding Allowed");
// }
// else
// {
//     Console.WriteLine("Boarding not allowed");
// }










// ===================== Solution: 2nd Problem ======================//

float creditScore, annualIncome, yearsPassedAtCurrentJob;

// taking inputs from user
Console.Write("Kindly Enter your credit score: ");
creditScore = float.Parse(Console.ReadLine());

Console.Write("Kindly enter your annual income in $: ");
annualIncome = float.Parse(Console.ReadLine());

Console.Write("How many years passed at your current job? ");
yearsPassedAtCurrentJob = float.Parse(Console.ReadLine());


// applying conditions
if (creditScore > 700 && annualIncome > 40_000 && yearsPassedAtCurrentJob > 1)
{
    Console.WriteLine("Loan Approved");
}
else
{
    Console.WriteLine("Loan Denied");
}
