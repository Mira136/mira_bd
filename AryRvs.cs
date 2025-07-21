using System;

namespace mira_bd
{
    class AryRvs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter array elements: ");

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Array in reverse order: ");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");

            Console.WriteLine();
        }
    }
}



