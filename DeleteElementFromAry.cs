using System;

namespace mira_bd
{
    class DeleteElementFromAry
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the position (1 to " + size + ") to delete element: ");
            int position = Convert.ToInt32(Console.ReadLine());

            if (position < 1 || position > size)
            {
                Console.WriteLine("Invalid position! No element deleted.");
            }
            else
            {
                for (int i = position - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size--;

                Console.WriteLine("\nArray after deleting element at position " + position + ":");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
