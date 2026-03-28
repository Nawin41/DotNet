using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class A2Q2
    {
        public static void Run()
        {
            Console.Write("Enter day number: ");
            int day = int.Parse(Console.ReadLine());

            if (day == 1)
                Console.WriteLine("Monday");
            else if (day == 2)
                Console.WriteLine("Tuesday");
            else if (day == 3)
                Console.WriteLine("Wednesday");
            else if (day == 4)
                Console.WriteLine("Thursday");
            else if (day == 5)
                Console.WriteLine("Friday");
            else if (day == 6)
                Console.WriteLine("Saturday");
            else if (day == 7)
                Console.WriteLine("Sunday");
            else
                Console.WriteLine("Invalid input");
        }
    }
}
