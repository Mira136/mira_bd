using System;

namespace mira_bd
{
    class SortDescending
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the array elements:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("\nArray elements in descending order:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
