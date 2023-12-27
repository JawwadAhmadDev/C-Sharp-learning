// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, secondName, fullName;

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your second name");
            string firstName = Console.ReadLine();

            fullName = firstName + secondName;

            Console.WriteLine("Your full name is " + fullName);
        }
    }
}