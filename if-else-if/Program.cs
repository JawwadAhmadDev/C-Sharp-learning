// ================= Solution: 1st Problem ================== //
// Tiered Tax Calculation Based on Income and Filing Status

// // variable declarations
// double income, tax;
// bool married;


// // taking inputs from user.
// Console.log("Please enter your income: ");
// income = double.parse(Console.ReadLine());

// Console.log("Please enter your married status(0 for unmarried / 1 for married): ");
// married = int.Parse(Console.ReadLine()) == 0 ? false : true;


// if (married)
// {
//     if (income <= 40000)
//     {
//         tax = income * 0.2;
//     }
//     else if (income <= 85000)
//     {
//         tax = 4000 + (income - 40000) * 0.4;
//     }
//     else
//     {
//         tax = 13000 + (income - 85000) * 0.6;
//     }
// }
// else
// {
//     if (income <= 40000)
//     {
//         tax = income * 0.1;
//     }
//     else if (income <= 85000)
//     {
//         tax = 4000 + (income - 40000) * 0.2;
//     }
//     else
//     {
//         tax = 13000 + (income - 85000) * 0.3;
//     }
// }

// Console.WriteLine($"\nYour Income: {income}\nMarried Status: {married}\nTax amount: ${tax}");
















// ================= Solution: 2n Problem ================== //
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
