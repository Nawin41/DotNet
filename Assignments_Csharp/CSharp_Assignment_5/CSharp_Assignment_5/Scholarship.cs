using System;

namespace CSharp_Assignment_5
{
    internal class Scholarship
    {
        public static void ApplyScholarship()
        {
            try
            {
                Console.WriteLine("Enter Marks:");
                int marks = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Fees:");
                double fees = double.Parse(Console.ReadLine());

                double amount = Merit(marks, fees);

                Console.WriteLine("Scholarship Amount is: " + amount);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        public static double Merit(int marks, double fees)
        {
            double scholarship = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarship = fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarship = fees * 0.30;
            }
            else if (marks > 90)
            {
                scholarship = fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException("Scholarship not applicable for the given marks.");
            }

            return scholarship;
        }
    }

    //User-defined Exception
    internal class InvalidMarksException : Exception
    {
        public InvalidMarksException(string message) : base(message)
        {
        }
    }
}