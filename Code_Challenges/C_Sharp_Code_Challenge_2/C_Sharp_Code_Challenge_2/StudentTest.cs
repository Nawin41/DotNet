using System;

namespace C_Sharp_Code_Challenge_2
{
    class StudentTest
    {
        public static void TestStudents()
        {
            //Undergraduate
            Undergraduate ug = new Undergraduate();

            Console.WriteLine("Enter Undergraduate Name:");
            ug.Name = Console.ReadLine();

            Console.WriteLine("Enter Undergraduate ID:");
            ug.StudentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Undergraduate Grade:");
            ug.Grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Passed: " + ug.IsPassed(ug.Grade));
            Console.WriteLine();

            //Graduate
            Graduate g = new Graduate();

            Console.WriteLine("Enter Graduate Name:");
            g.Name = Console.ReadLine();

            Console.WriteLine("Enter Graduate ID:");
            g.StudentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Graduate Grade:");
            g.Grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Passed: " + g.IsPassed(g.Grade));
        }
    }
}