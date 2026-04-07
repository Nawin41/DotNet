using System;
using System.IO;

//Question 2

namespace CSharp_Assignment_6
{
    class file_creation
    {
        public static void Execute()
        {
            string filePath = "C:\\Training_DotNet\\Assignments_Csharp\\CSharp_Assignment_6\\MyTextFile.txt";

            
            string[] lines =
            {
                "Hello",
                "World",
                "Let's",
                "Learn",
                "Dot Net"
            };

            
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Data written to file successfully.\n");

            
            Console.WriteLine("Reading data from file:\n");
            string[] readLines = File.ReadAllLines(filePath);

            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
