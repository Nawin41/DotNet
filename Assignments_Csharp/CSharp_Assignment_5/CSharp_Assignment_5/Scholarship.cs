using System;

namespace CSharp_Assignment_5
{
    internal class Scholarship
    {
        public static void ApplyScholarship()
        {
            try
            {
                Console.WriteLine("Enter student marks:");
                int marks = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter total fees:");
                double fees = double.Parse(Console.ReadLine());

                double scholarshipAmount = Merit(marks, fees);

                Console.WriteLine("Scholarship Amount: " + scholarshipAmount);
            }
            catch (InvalidMarksException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.ReadLine();
        }

        public static double Merit(int marks, double fees)
        {
            double amount = 0;

            if (marks >= 70 && marks <= 80)
            {
                amount = fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                amount = fees * 0.30;
            }
            else if (marks > 90)
            {
                amount = fees * 0.50;
            }
            else
            {
                throw new InvalidMarksException("Scholarship not applicable for given marks.");
            }

            return amount;
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