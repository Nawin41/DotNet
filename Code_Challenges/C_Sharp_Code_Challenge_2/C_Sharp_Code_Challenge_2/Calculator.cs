using System;

namespace C_Sharp_Code_Challenge_2
{
    class Calculator
    {
        //Delegate declaration
        public delegate int Operation(int a, int b);

        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }    
        public static void RunCalculator()
        {
            Console.WriteLine("Enter first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = int.Parse(Console.ReadLine());

            Operation op;

            //Addition
            op = Add;
            Console.WriteLine("Addition Result: " + op(num1, num2));

            //Subtraction
            op = Subtract;
            Console.WriteLine("Subtraction Result: " + op(num1, num2));

            //Multiplication
            op = Multiply;
            Console.WriteLine("Multiplication Result: " + op(num1, num2));
        }
    }
}