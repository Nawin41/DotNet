using System;
using class_library;

namespace CSharp_Assignment_7
{
    internal class Program
    {
        const int TotalFare = 500;

        static void Main(string[] args)
        {
            // Question 1
            //square_number.sq_num();
            // Question 2
            //start_end_word.word_check();
            // Question 3
            //employee_list.emp_data();
            //Question 4
            Console.WriteLine("\n--- Travel Concession ---");

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Passenger Name: " + name);

            Concession c = new Concession();
            c.CalculateConcession(age, TotalFare);

            Console.ReadLine();
        }
    }
}