// ========================Solution: 1st Problem=====================//
// double purchases;
// bool isPremiumMember;

// Console.Write("Please enter your purchases amount: ");
// purchases = int.Parse(Console.ReadLine());

// Console.Write("Are you a premium member (0 for non-premium and 1 for premium): ");
// isPremiumMember = int.Parse(Console.ReadLine()) == 0 ? false : true;


// if (purchases >= 100 && isPremiumMember)
// {
//     Console.WriteLine("Congradtions! You are eligible for discount");
// }








// ========================Solution: 2nd Problem=====================//
float age;
bool hasPreExistingCondition;

Console.Write("Please enter your age: ");
age = int.Parse(Console.ReadLine());

Console.Write("Have you pre-existing heart conditions (0 for No and 1 for Yes): ");
hasPreExistingCondition = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (age > 65 && !hasPreExistingCondition)
{
    Console.WriteLine("Congradtions! You are eligible for the program");
}