// Discount Eligibility Check Based on Purchase Amount and Membership Status
// Write a program that determines if a customer is eligible for a discount. 
// If the customer's purchase amount exceeds $100 and they are a premium member, then they are eligible for a discount. Print "Eligible for discount" if these conditions are met.

// Program Starts
double purchases;
bool isPremiumMember;

Console.Write("Please enter your purchases amount: ");
purchases = int.Parse(Console.ReadLine());

Console.Write("Are you a premium member (0 for non-premium and 1 for premium): ");
isPremiumMember = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (purchases >= 100 && isPremiumMember)
{
    Console.WriteLine("Congradtions! You are eligible for discount");
}