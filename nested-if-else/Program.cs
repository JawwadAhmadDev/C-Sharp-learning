/*
// ===================== 1st Problem: solution =================== //
// Problem Statement: Academic Eligibility for Scholarship

// taking inputs from the user.
Console.WriteLine("Enter your GPA:");
double gpa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the number of extracurricular activities participated in:");
int activities = Convert.ToInt32(Console.ReadLine());

// if both conditions are met, then student is eligible.
if (gpa >= 3.5)
{
    if (activities > 3)
    {
        Console.WriteLine("You are eligible for the scholarship.");
    }
    else
    {
        Console.WriteLine("You are not eligible due to shortage of activities.");
    }
}
else
{
    Console.WriteLine("You are not eligible due to less gpa.");
}








// ===================== 2nd Problem: solution =================== //
// Problem Statement: Restaurant Health and Safety Inspection

// taking inputs from user.
Console.Write("Did the restaurant pass the basic hygiene test? (yes/no): ");
string hygieneTest = Console.ReadLine();
Console.Write("Is the kitchen equipment up to standard? (yes/no): ");
string equipmentStandard = Console.ReadLine();
Console.Write("Do staff have valid health certificates? (yes/no): ");
string staffHealth = Console.ReadLine();

// check if all the conditions are met.
if (hygieneTest == "yes")
{
    if (equipmentStandard == "yes")
    {
        if (staffHealth == "yes")
        {
            Console.WriteLine("The restaurant passes the inspection.");
        }
        else
        {
            Console.WriteLine("The restaurant doesn't pass the inspection due to incompletion of staffHealth.");
        }
    }
    else
    {
        Console.WriteLine("The restaurant doesn't pass the inspection due to not meet equipment standard.");
    }
}
else
{
    Console.WriteLine("The Restaurant doesn't pass the inspection due to hygiene test.");
}
*/








// ===================== 3rd Problem: solution =================== //
// Problem Statement: Customized Travel Recommendations


// taking input from the user.
Console.Write("Do you prefer outdoor activities? (yes/no): ");
string outdoorPref = Console.ReadLine();
Console.Write("Do you like hiking? (yes/no): ");
string hikingPref = Console.ReadLine();
Console.Write("Do you prefer cold weather? (yes/no): ");
string coldWeatherPref = Console.ReadLine();


// printing statement accoridng to the conditions met.
if (outdoorPref == "yes")
{
    if (hikingPref == "yes")
    {
        if (coldWeatherPref == "yes")
        {
            Console.WriteLine("We recommend a mountainous region with a colder climate for your trip.");
        }
        else
        {
            Console.WriteLine("We recommend a mountainous region for your trip.");
        }
    }
    else
    {
        Console.WriteLine("We reccommend a ground region for you trip.");
    }
}
