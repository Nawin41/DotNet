using System;

namespace Assignment_2
{
    internal class Array2
    {
        public static void Run()
        {
            int[] marks = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 marks:");

            //Input
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter mark " + (i + 1) + ": ");
                marks[i] = int.Parse(Console.ReadLine());
                sum = sum + marks[i];
            }

            int min = marks[0];
            int max = marks[0];

            //Find min and max
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < min)
                    min = marks[i];

                if (marks[i] > max)
                    max = marks[i];
            }

            double avg = (double)sum / marks.Length;

            Console.WriteLine("Total = " + sum);
            Console.WriteLine("Average = " + avg);
            Console.WriteLine("Minimum = " + min);
            Console.WriteLine("Maximum = " + max);

            //Ascending order
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            Console.WriteLine("Ascending Order:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + " ");
            }

            // Descending order
            Console.WriteLine("\nDescending Order:");
            for (int i = marks.Length - 1; i >= 0; i--)
            {
                Console.Write(marks[i] + " ");
            }
        }
    }
}