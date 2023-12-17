// ===================== Solution: 1st Problem ======================//

bool hasBoardingPass, securityPassed;
double luggageWeight;

// taking inputs from user
Console.Write("Have you a boarding pass? (0 for false / 1 for true): ");
hasBoardingPass = int.Parse(Console.ReadLine()) == 0 ? false : true;

Console.Write("Please enter you luggage weight: ");
luggageWeight = double.Parse(Console.ReadLine());

Console.Write("Are you security passed? (0 for false / 1 for true): ");
securityPassed = int.Parse(Console.ReadLine()) == 0 ? false : true;


// applying conditions
if (hasBoardingPass && luggageWeight < 20 && securityPassed)
{
    Console.WriteLine("Boarding Allowed");
}
else
{
    Console.WriteLine("Boarding not allowed");
}
