using System;
using System.Collections;

public class Descending_Order
{
    public void SortStackDescending()
    {
        Stack stack = new Stack();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            int val = int.Parse(Console.ReadLine());
            stack.Push(val);
        }

      
        int[] arr = new int[stack.Count];
        int index = 0;

        foreach (int item in stack)
        {
            arr[index++] = item;
        }

        
        Array.Sort(arr);

        
        Stack sortedStack = new Stack();

        foreach (int item in arr)
        {
            sortedStack.Push(item);
        }

        //Descending order
        Console.WriteLine("\nStack elements in descending order:");
        foreach (int item in sortedStack)
        {
            Console.WriteLine(item);
        }
    }
}