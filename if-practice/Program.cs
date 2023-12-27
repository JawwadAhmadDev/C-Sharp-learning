// ========================Solution: 1st Problem=====================//
double purchases;
bool isPremiumMember;

Console.Write("Please enter your purchases amount: ");
purchases = double.Parse(Console.ReadLine());

Console.Write("Are you a premium member (0 for non-premium and 1 for premium): ");
isPremiumMember = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (purchases >= 100 && isPremiumMember)
{
    Console.WriteLine("Congradtions! You are eligible for discount");
}








// ========================Solution: 2nd Problem=====================//
float age;
bool hasPreExistingCondition;

Console.Write("Please enter your age: ");
age = float.Parse(Console.ReadLine());

Console.Write("Have you pre-existing heart conditions (0 for No and 1 for Yes): ");
hasPreExistingCondition = int.Parse(Console.ReadLine()) == 0 ? false : true;


if (age > 65 && !hasPreExistingCondition)
{
    Console.WriteLine("Congradtions! You are eligible for the program");
}






// ========================Solution: 3rd Problem=====================//
float gradesPercent;
int extracurricularActivities;

Console.Write("Please enter your grades precent: ");
gradesPercent = float.Parse(Console.ReadLine());

Console.Write("In how many extracurricular activties, you have participated: ");
extracurricularActivities = int.Parse(Console.ReadLine());


if (gradesPercent >= 90 && extracurricularActivities >= 2)
{
    Console.WriteLine("Congradtions! You are eligible for the scholarship");
}





// ========================Solution: 4th Problem=====================//
float temprature, humidity, windSpeed;

Console.Write("Please enter temprature in Fahrenheit: ");
temprature = float.Parse(Console.ReadLine());

Console.Write("Please enter humidity in percent: ");
humidity = float.Parse(Console.ReadLine());

Console.Write("Please enter wind speed: ");
windSpeed = float.Parse(Console.ReadLine());


if (temprature > 95 && humidity > 80 && windSpeed > 20)
{
    Console.WriteLine("=====Severe weather warning==========");
}









// ======================== Solution: 5th Problem=====================//
string password;

Console.Write("Please Enter a password: ");
password = Console.ReadLine();

if (password.Length >= 8 &&
    password.Any(char.IsUpper) &&
    password.Any(char.IsLower) &&
    password.Any(char.IsDigit))
{
    Console.WriteLine("Password is strong");
}