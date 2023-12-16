// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Please enter your age");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Entered age: " + age);
            
        }
    }
}