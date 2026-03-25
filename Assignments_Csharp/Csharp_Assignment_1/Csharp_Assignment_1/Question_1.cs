using System;


namespace Csharp_Assignment_1
{
    // Question 1: Write a C# program to check if two numbers are equal or not.
    internal class Question_1
    {
        public static void Run()
        {
            Console.Write("Input 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are equal");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are not equal");
            }
        }
    }
}
