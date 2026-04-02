using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Question 2
public class String_Exchange
{
    //Method to swap first and last characters
    public void SwapFirstLast()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        
        if (str.Length <= 1)
        {
            Console.WriteLine("Result: " + str);
        }
        else
        {
            
            char first = str[0];
            char last = str[str.Length - 1];

            
            string middle = str.Substring(1, str.Length - 2);

            string result = last + middle + first;

            Console.WriteLine("Result: " + result);
        }
    }
}