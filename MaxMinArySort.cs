using System;

namespace mira_bd
{
    class MaxMinArySort
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr); 

            Console.WriteLine("Minimum element: " + arr[0]);
            Console.WriteLine("Maximum element: " + arr[n - 1]);
        }
    }
}
