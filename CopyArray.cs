using System;

namespace mira_bd
{
    class CopyArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] originalAry = new int[size];
            int[] copiedAry = new int[size];

            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalAry[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < size; i++)
            {
                copiedAry[i] = originalAry[i];
            }

            Console.WriteLine("\nElements copied to the new array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(copiedAry[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
