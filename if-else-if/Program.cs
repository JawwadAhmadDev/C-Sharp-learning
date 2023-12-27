// ================= Solution: 1st Problem ================== //
// Tiered Tax Calculation Based on Income and Filing Status

// // variable declarations
double income, tax;
bool married;

// taking inputs from user.
Console.log("Please enter your income: ");
income = double.parse(Console.ReadLine());

Console.log("Please enter your married status(0 for unmarried / 1 for married): ");
married = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (married)
{
    if (income <= 40000)
    {
        tax = income * 0.2;
    }
    else if (income <= 85000)
    {
        tax = 4000 + (income - 40000) * 0.4;
    }
    else
    {
        tax = 13000 + (income - 85000) * 0.6;
    }
}
else
{
    if (income <= 40000)
    {
        tax = income * 0.1;
    }
    else if (income <= 85000)
    {
        tax = 4000 + (income - 40000) * 0.2;
    }
    else
    {
        tax = 13000 + (income - 85000) * 0.3;
    }
}

Console.WriteLine($"\nYour Income: {income}\nMarried Status: {married}\nTax amount: ${tax}");
















// ================= Solution: 2nd Problem ================== //
// Customized Fitness Program Based on Age, Gender, and Fitness Level

using System;
namespace If_Else_If
{
    class fitnessLevelTracker
    {
        enum Gender
        {
            male, female
        };
        enum FitnessLevel
        {
            beginner, intermediate, advance
        }

        static void Main(string[] args)
        {
            int age;

            // taking input from user
            Console.Write("Please enter your age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Pleasse enter your gender(0 for female / 1 for male): ");
            Gender gender = int.Parse(Console.ReadLine()) == 0 ? Gender.female : Gender.male;

            Console.Write("Please enter your fitness level(0 for beginner, 1 for intermediate, 2 for advance): ");
            int userInput = int.Parse(Console.ReadLine());
            FitnessLevel fitnessLevel = userInput == 0 ? FitnessLevel.beginner :
                                        userInput == 1 ? FitnessLevel.intermediate : FitnessLevel.advance;

            if (age < 30)
            {
                if (fitnessLevel == FitnessLevel.beginner)
                {
                    Console.WriteLine("Suggested beginner program");
                }
                else if (fitnessLevel == FitnessLevel.intermediate)
                {
                    Console.WriteLine("Suggested intermediate program");
                }
                else
                {
                    Console.WriteLine("Suggested Advance Level");
                }
            }
            else
            {
                if (fitnessLevel == FitnessLevel.beginner || fitnessLevel == FitnessLevel.intermediate)
                {
                    Console.WriteLine("Suggested Beginner Level");
                }
                else
                {
                    Console.WriteLine("Suggested Intermediate level");
                }
            }
        }
    }
}










// ================= Solution: 3rd Problem ================== //
// Advanced Academic Track Placement Based on Test Scores in Multiple Subjects

int mathScore;
int scienceScore;
int languageArtsScore;

Console.Write("Please enter your maths scores: ");
mathScore = int.Parse(Console.ReadLine());

Console.Write("Please enter your science marks: ");
scienceScore = int.Parse(Console.ReadLine());

Console.Write("Please enter arts score: ");
languageArtsScore = int.Parse(Console.ReadLine());



if (mathScore > 80 && scienceScore > 80 && languageArtsScore > 80)
{
    Console.WriteLine("Assigned to honors track");
}
else if (mathScore > 70 && scienceScore > 70)
{
    Console.WriteLine("Assigned to advanced track");
}
else
{
    Console.WriteLine("Assigned to basic track");
}









// ================= Solution: 4th Problem ================== //
// // CDynamic Pricing Model for an Event Based on Date, Demand, and Member Status
int daysBeforeEvent;
int currentDemandLevel; // scale of 1-10
bool isMember;
double price;

Console.Write("How many days before you want ticket: ");
daysBeforeEvent = int.Parse(Console.ReadLine());

Console.Write("What is current demand level: ");
currentDemandLevel = int.Parse(Console.ReadLine());

Console.Write("Are you a member of the organization(0 for No / 1 for Yes): ");
isMember = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (daysBeforeEvent > 30)
{
    price = 50; // early bird price
}
else if (currentDemandLevel > 7)
{
    price = 80; // high demand price
}
else
{
    price = 65; // regular price
}
if (isMember)
{
    price *= 0.9; // 10% discount for members
}
Console.WriteLine($"Ticket price: ${price}");










// ================= Solution: 5th Problem ================== //
// Advanced Home Loan Eligibility System Based on Multiple Financial Parameters


// Taking input from user
int creditScore;
Console.Write("Please enter your credit socre: ");
creditScore = int.Parse(Console.ReadLine());

double monthlyIncome;
Console.Write("Please enter your monthly income: ");
monthlyIncome = double.Parse(Console.ReadLine());

double monthlyDebts;
Console.Write("Kindly enter your monthly debts: ");
monthlyDebts = double.Parse(Console.ReadLine());

double downPaymentPercentage;
Console.Write("Kindly enter your down payment percentage: ");
downPaymentPercentage = double.Parse(Console.ReadLine());

bool isEligible;
double interestRate;


// applying conditions
if (creditScore > 700 && monthlyIncome / monthlyDebts > 2 && downPaymentPercentage >= 20)
{
    isEligible = true;
    interestRate = creditScore > 750 ? 3.5 : 4.0;
}
else
{
    isEligible = false;
    interestRate = 0;
}
Console.WriteLine(isEligible ? $"Loan Eligible at {interestRate}% interest rate" : "Loan Not Eligible");

