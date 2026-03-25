using System;


namespace Csharp_Assignment_1
{
    //4. Write a C# Sharp program that prints the multiplication table of a number as input.
    internal class Question_4
    {
        public static void Run()
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            int i;

            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}
