
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
