using System;

namespace C_Sharp_Code_Challenge_2
{
    abstract class Student
    {
        public string Name;
        public int StudentId;
        public double Grade;

        public abstract bool IsPassed(double grade);
    }
}