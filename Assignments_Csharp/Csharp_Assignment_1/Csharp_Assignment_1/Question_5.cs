using System;


namespace Csharp_Assignment_1
{
    internal class Question_5
    {
        //5.  Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.
        public static void Run()
        {
            Console.Write("Enter 1st number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine("Triple sum = " + (sum * 3));
            }
            else
            {
                Console.WriteLine("Sum = " + sum);
            }
        }
    }
}
