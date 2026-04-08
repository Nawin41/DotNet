using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Code_Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Code challenge 1 Question 1 - Employee Management System
            Emp_management_system emp_system = new Emp_management_system();
            emp_system.Run();

            //Code challenge 1 Question 2 - Employee Structure

            Employee_Structure emp_str = new Employee_Structure();
            emp_str.Run();
        }
    }
}