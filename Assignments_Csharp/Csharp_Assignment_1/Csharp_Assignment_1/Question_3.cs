using System;


namespace Csharp_Assignment_1
{
    //Question 3:  Write a C# Sharp program that takes two numbers as input and performs all operations (+,-,*,/) on them and displays the result of that operation.
    internal class Question_3
    {
        public static void Run()
        {
            Console.WriteLine("Question 3");

            Console.Write("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("Input second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            }
            else if (op == '-')
            {
                Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            }
            else if (op == '*')
            {
                Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
            }
            else if (op == '/')
            {
                if (num2 != 0)
                {
                    Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation");
            }

            Console.WriteLine();
        }
    }
}
