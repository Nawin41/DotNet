using System;

namespace C_Sharp_Code_Challenge_2
{
    class Undergraduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }
}