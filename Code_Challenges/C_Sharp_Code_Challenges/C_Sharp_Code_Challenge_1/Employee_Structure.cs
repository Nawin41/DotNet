using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Code_Challenge_1
{
    class Employee_Structure
    {
        // Nested structure
        struct BirthDate
        {
            public int Day;
            public int Month;
            public int Year;
        }

        struct Employee
        {
            public string Name;
            public BirthDate DOB;
        }

        public void Run()
        {
            Employee[] emp = new Employee[2];

            Console.WriteLine("----Create a nested structure and store data in an array :----");

            for (int i = 0; i < emp.Length; i++)
            {
                Console.Write("Name of the employee : ");
                emp[i].Name = Console.ReadLine();

                Console.Write("Input day of the birth : ");
                emp[i].DOB.Day = int.Parse(Console.ReadLine());

                Console.Write("Input month of the birth : ");
                emp[i].DOB.Month = int.Parse(Console.ReadLine());

                Console.Write("Input year for the birth : ");
                emp[i].DOB.Year = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("----Employee Details:----");

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Name : " + emp[i].Name);
                Console.WriteLine("Date of Birth : " + emp[i].DOB.Day + "/" + emp[i].DOB.Month + "/" + emp[i].DOB.Year);
                Console.WriteLine();
            }
        }
    }
}