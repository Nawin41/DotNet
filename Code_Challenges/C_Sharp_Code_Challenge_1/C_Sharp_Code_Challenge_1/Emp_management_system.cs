using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C_Sharp_Code_Challenge_1
{
    class Emp_management_system
    {
        List<Employee> empList = new List<Employee>();

        public void Run()
        {
            int choice = 0;

            while (choice != 6)
            {
                //Display options
                Console.WriteLine();
                Console.WriteLine("-------Employee Management------");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. View All Employees");
                Console.WriteLine("3. Search Employee by ID");
                Console.WriteLine("4. Update Employee Details");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("------------------------------");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                //selecting choice
                if (choice == 1)
                {
                    AddEmployee();
                }
                else if (choice == 2)
                {
                    ViewEmployees();
                }
                else if (choice == 3)
                {
                    SearchEmployee();
                }
                else if (choice == 4)
                {
                    UpdateEmployee();
                }
                else if (choice == 5)
                {
                    DeleteEmployee();
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Thank You-Program exits");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter Id: ");
            emp.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            empList.Add(emp);

            Console.WriteLine("Employee added.");
        }

        void ViewEmployees()
        {
            if (empList.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            for (int i = 0; i < empList.Count; i++)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Id: " + empList[i].Id);
                Console.WriteLine("Name: " + empList[i].Name);
                Console.WriteLine("Department: " + empList[i].Department);
                Console.WriteLine("Salary: " + empList[i].Salary);
            }
        }

        void SearchEmployee()
        {
            Console.Write("Enter Id to search: ");
            int id = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].Id == id)
                {
                    Console.WriteLine("Employee found");
                    Console.WriteLine("Name: " + empList[i].Name);
                    Console.WriteLine("Department: " + empList[i].Department);
                    Console.WriteLine("Salary: " + empList[i].Salary);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }

        void UpdateEmployee()
        {
            Console.Write("Enter Id to update: ");
            int id = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].Id == id)
                {
                    Console.Write("Enter new Name: ");
                    empList[i].Name = Console.ReadLine();

                    Console.Write("Enter new Department: ");
                    empList[i].Department = Console.ReadLine();

                    Console.Write("Enter new Salary: ");
                    empList[i].Salary = double.Parse(Console.ReadLine());

                    Console.WriteLine("Employee updated.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }

        void DeleteEmployee()
        {
            Console.Write("Enter Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < empList.Count; i++)
            {
                if (empList[i].Id == id)
                {
                    empList.RemoveAt(i);
                    Console.WriteLine("Employee deleted.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }

    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;
    }
}