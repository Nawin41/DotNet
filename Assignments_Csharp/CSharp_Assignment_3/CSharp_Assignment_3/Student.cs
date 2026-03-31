using System;

public class Student
{
    //Data
    int rollNo;
    string name;
    string studentClass;
    int semester;
    string branch;

    //Array to store marks
    int[] marks = new int[5];

    //Constructor
    public Student(int r, string n, string c, int sem, string b)
    {
        rollNo = r;
        name = n;
        studentClass = c;
        semester = sem;
        branch = b;
    }

    //Method to input marks for 5 subjects
    public void GetMarks()
    {
        Console.WriteLine("Enter marks for 5 subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = int.Parse(Console.ReadLine());
        }
    }

    //Method to calculate average and display result
    public void DisplayResult()
    {
        int total = 0;          
        bool isFail = false;    
       
        for (int i = 0; i < 5; i++)
        {
            if (marks[i] < 35)  
            {
                isFail = true;
            }
            total += marks[i]; 
        }

        double average = total / 5.0; 
        

        Console.WriteLine("Average Marks: " + average);

        //Result
        if (isFail)
        {
            Console.WriteLine("Result: Failed");
        }
        else if (average < 50)
        {
            Console.WriteLine("Result: Failed");
        }
        else
        {
            Console.WriteLine("Result: Passed");
        }
    }

    //Method to display student details
    public void DisplayData()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Class: " + studentClass);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("Branch: " + branch);
    }

    public static void Start()
    {
        //Taking input from user
        Console.Write("Enter Roll No: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Class: ");
        string cls = Console.ReadLine();

        Console.Write("Enter Semester: ");
        int sem = int.Parse(Console.ReadLine());

        Console.Write("Enter Branch: ");
        string branch = Console.ReadLine();

        
        Student s = new Student(roll, name, cls, sem, branch);

        //Calling methods
        s.GetMarks();     
        s.DisplayData();    
        s.DisplayResult();  
    }
}