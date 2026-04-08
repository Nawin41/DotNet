using System;

namespace C_Sharp_Code_Challenge_2
{
    class Graduate : Student
    {
        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }
}