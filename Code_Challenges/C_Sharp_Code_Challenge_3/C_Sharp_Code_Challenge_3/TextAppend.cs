using System;
using System.IO;

public class TextAppend
{
    public static void AppendTextToFile()
    {
        string filePath = "SampleFile1.txt";

        Console.WriteLine("Enter text to append into the file:");
        string text = Console.ReadLine();

        //StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(text);
        }

        Console.WriteLine("Text appended successfully.");
    }
}