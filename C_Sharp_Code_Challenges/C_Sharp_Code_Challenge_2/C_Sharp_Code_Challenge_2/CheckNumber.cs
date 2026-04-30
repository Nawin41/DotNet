using System;

namespace C_Sharp_Code_Challenge_2
{
    class CheckNumber
    {
        //throws exception
        public static void Validate(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number should not be negative");
            }

            Console.WriteLine("Valid number: " + number);
        }

        //handles exception
        public static void Negative_finder()
        {
            try
            {
                Console.WriteLine("Enter an integer:");
                int num = int.Parse(Console.ReadLine());

                Validate(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught: " + ex.Message);
            }
        }
    }
}