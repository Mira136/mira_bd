using System;

namespace mira_bd
{
    class AryCopy
    {
        static void Main(string[] args)
        {
            int[] original = { 1, 2, 3, 4, 5 };
            int[] copy = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }

            Console.WriteLine("Copied array: ");
            foreach (int val in copy)
                Console.Write(val + " ");

            Console.WriteLine();
        }
    }
}
