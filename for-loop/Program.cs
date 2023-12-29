/*
// ===================== 1st Problem: solution =================== //
// Problem Statement: Print a Pattern of Asterisks

// taking input from user.
Console.Write("Enter the number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

// printing pattern
for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}





// ===================== 2nd Problem: solution =================== //
// Problem Statement: Calculate the Sum of Odd Numbers in a Range

// taking input from user
Console.Write("Enter two numbers: ");
int start = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());

int sum = 0;

// calculating sum using for loop
for (int i = start; i <= end; i++)
{
    // check if the number is odd. if odd then add, skip otherwise.
    if (i % 2 != 0)
    {
        sum += i;
    }
}
Console.WriteLine("Sum of odd numbers from " + start + " to " + end + " : " + sum);











// ===================== 3rd Problem: solution =================== //
// Problem Statement: Display the Multiplication Table Up to X

// taking input from user.
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the limit: ");
int limit = Convert.ToInt32(Console.ReadLine());

// printing table of number upto limit
for (int i = 1; i <= limit; i++)
{
    Console.WriteLine(number + " * " + i + " = " + (number * i));
}









// ===================== 4th Problem: solution =================== //
// Problem Statement: Find All Substrings of a String

// taking input from user.
Console.WriteLine("Enter a string:");
string str = Console.ReadLine();

// printing each substring.
for (int i = 0; i < str.Length; i++)
{
    for (int j = i; j < str.Length; j++)
    {
        Console.WriteLine(str.Substring(i, j - i + 1)); // 1st: starting index, 2nd: length
    }
}
*/






// ===================== 5th Problem: solution =================== //
// Problem Statement: Count the Frequency of Each Element in an Array


// taking size of the array from user.
Console.WriteLine("Enter the size of the array:");
int size = Convert.ToInt32(Console.ReadLine());

// instantiated array with specified size.
int[] array = new int[size];
// Array to keep track of visited elements
bool[] visited = new bool[array.Length];


// taking elements of the array from user.
Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}


// Iterate through the array
for (int i = 0; i < array.Length; i++)
{
    // Skip this element if it's already been counted
    if (visited[i])
    {
        continue;
    }

    int count = 1;

    // Count how many times the current element appears
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] == array[j])
        {
            visited[j] = true;
            count++;
        }
    }

    Console.WriteLine($"Element {array[i]}: Frequency {count}");
}
