using System;

namespace Assignment_2
{
    internal class Array1
    {
        public static void Run()
        {
            int[] arr = new int[5];  

            Console.WriteLine("Enter 5 numbers:");

            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int min = arr[0];
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

                if (arr[i] < min)
                    min = arr[i];

                if (arr[i] > max)
                    max = arr[i];
            }

            double avg = (double)sum / arr.Length;

            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);
        }
    }
}