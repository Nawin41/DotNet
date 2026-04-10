using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Assignment_7
{
    internal class employee_list
    {
        class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public string EmpCity { get; set; }
            public double EmpSalary { get; set; }
        }

        public static void emp_data()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter number of employees: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for Employee {i + 1}");

                Console.Write("Emp Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Emp Name: ");
                string name = Console.ReadLine();

                Console.Write("Emp City: ");
                string city = Console.ReadLine();

                Console.Write("Emp Salary: ");
                double salary = double.Parse(Console.ReadLine());

                employees.Add(new Employee
                {
                    EmpId = id,
                    EmpName = name,
                    EmpCity = city,
                    EmpSalary = salary
                });
            }

            //Display all employees
            Console.WriteLine("\nAll Employees:");
                var allEmployees =from e in employees select e;

            foreach (var e in allEmployees)
                Display(e);

            //Salary > 45000
            Console.WriteLine("\nEmployees with Salary > 45000:");
            var highSalary = from e in employees where e.EmpSalary > 45000 select e;

            foreach (var e in highSalary)
                Display(e);

            //Employees from Bangalore
            Console.WriteLine("\nEmployees from Bangalore:");
            var bangaloreEmp =from e in employees where e.EmpCity == "Bangalore" select e;

            foreach (var e in bangaloreEmp)
                Display(e);

            //Ascending order by name
            Console.WriteLine("\nEmployees in Ascending Order of Name:");
            var sortedEmp = from e in employees orderby e.EmpName ascending select e;

            foreach (var e in sortedEmp)
                Display(e);
        }

        static void Display(Employee e)
        {
            Console.WriteLine(
                $"Id: {e.EmpId}, Name: {e.EmpName}, City: {e.EmpCity}, Salary: {e.EmpSalary}");
        }
    }
}
