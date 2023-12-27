// ===================== Solution: 1st Problem ======================//
// Flight Boarding Eligibility Based on Multiple Conditions

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










// ===================== Solution: 2nd Problem ======================//
// Advanced Loan Approval System Based on Credit Score, Income, and Employment Status

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












// ===================== Solution: 3rd Problem ======================//
// Energy Bill Calculation Based on Usage and Peak Hours
int units;
double bill, rate;

// taking inputs from user
Console.Write("Kindly Enter your energy usage in units (kWh): ");
units = int.Parse(Console.ReadLine());

// applying conditions
if (units < 500)
{
    rate = 0.15;
    bill = units * rate;
}
else
{
    rate = 0.18;
    bill = units * rate;
}


Console.WriteLine($"\nRate per unit: {rate}\nYour current bill is {bill}");












// ===================== Solution: 4th Problem ======================//
// Customized Diet Plan Based on Age, Weight, and Activity Level

using System;
namespace If_Else_practice
{
    class DietPlan
    {
        enum ActivityLevel
        {
            Low,
            High
        };

        static void Main(string[] args)
        {
            // variable declaration.
            float age, weight;

            // taking input from user
            Console.Write("Please enter your age: ");
            age = float.Parse(Console.ReadLine());

            Console.Write("Please enter your activity level(0 for low / 1 for high): ");
            ActivityLevel activityLevel = int.Parse(Console.ReadLine()) == 0 ? ActivityLevel.Low : ActivityLevel.High;


            // applying conditions
            if (age < 30 && activityLevel == ActivityLevel.High)
            {
                Console.WriteLine("You are suggested a high protein diet");
            }
            else
            {
                Console.WriteLine("You are suggested a low carb diet");
            }
        }
    }
}









// ===================== Solution: 5th Problem ======================//
// Advanced Vehicle Maintenance Check Based on Mileage, Age, and Service Historyel


// variable declarations.
float drivenMiles, age;
bool servicedInLastyear;

Console.Write("How many miles your vehicle has driven: ");
drivenMiles = float.Parse(Console.ReadLine());

Console.Write("How much is your vehicle: ");
age = float.Parse(Console.ReadLine());

Console.Write("Is your vehicle serviced last year or not? (0 for No / 1 for Yes): ");
servicedInLastyear = int.Parse(Console.ReadLine()) == 0 ? false : true;


// applying conditions
if (drivenMiles > 10_000 && age > 3 && !servicedInLastyear)
{
    Console.WriteLine("Your vehicle requires a maintenance.");
}
else
{
    Console.WriteLine("Maintenance not required.");
}
