using System;

namespace mira_bd
{
    class SortArray
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];

            Console.WriteLine("Enter 5 integer values:");

            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(n);
            Console.WriteLine("\nSorted array in ascending order:");

            foreach (int num in n)
            {
                Console.WriteLine(num);
            }
        }
    }
}
