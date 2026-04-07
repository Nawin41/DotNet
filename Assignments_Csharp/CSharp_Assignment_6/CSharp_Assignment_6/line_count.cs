using System;
using System.IO;

//Question 3
namespace CSharp_Assignment_6
{
    class line_count
    {
        public static void Execute()
        {
            string filePath = "C:\\Training_DotNet\\Assignments_Csharp\\CSharp_Assignment_6\\MyTextFile.txt";

            
            if (File.Exists(filePath))
            {
                
                string[] lines = File.ReadAllLines(filePath);

                //Count number of lines
                int lineCount = lines.Length;

                Console.WriteLine($"Total number of lines in the file: {lineCount}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
    }
}