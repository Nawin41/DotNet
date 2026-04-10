using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Assignment_7
{
    internal class square_number
    {
        public static void sq_num()
        {
            List<int> numbers = new List<int>();

            Console.Write("Enter how many numbers: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            var result = from n in numbers
                         let square = n * n
                         where square > 20
                         select new { Number = n, Square = square };

            Console.WriteLine("\nResult:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Number} - {item.Square}");
            }
        }
    }
}