using System;

namespace Assignment_2
{
    //Copying elements from one array to another array
    internal class Array3
    {
        public static void Run()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            Console.WriteLine("Enter 5 elements for first array:");

            //Input for first array
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            //Copy
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Elements of second array (copied):");

            //second array
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}