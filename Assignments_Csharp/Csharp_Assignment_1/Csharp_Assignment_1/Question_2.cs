using System;


namespace Csharp_Assignment_1
{
    // Question 2: Write a C# program to check if a number is positive or negative.
   
    internal class Question_2
    {
        public static void Run()
        {
            Console.WriteLine("Question 2");

            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine(num + " is a positive number");
            }
            else
            {
                Console.WriteLine(num + " is a negative number");
            }

            Console.WriteLine();
        }

    }
}
