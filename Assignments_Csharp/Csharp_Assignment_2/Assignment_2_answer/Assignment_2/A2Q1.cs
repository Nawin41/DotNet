using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    //Question 1: Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice:

    internal class A2Q1
    {
        public static void Run()
        {
            Console.Write("Enter a digit: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(num + " " + num + " " + num + " " + num);
            Console.WriteLine("" + num + num + num + num);
            Console.WriteLine(num + " " + num + " " + num + " " + num);
            Console.WriteLine("" + num + num + num + num);
        }
    }
}

