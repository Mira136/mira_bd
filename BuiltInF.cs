using System;
using System.Linq;

namespace mira_bd
{
    class BuiltInF
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 7, 3, 4, 10, 20, 11, 12 };

            Console.WriteLine("Max num: " + a.Max());
            Console.WriteLine("Min num: " + a.Min());

            Console.WriteLine();

            var reverse = a.Reverse();
            Console.WriteLine("Reversed num is: ");
            foreach (int i in reverse)
                Console.Write(i + " ");

            Console.WriteLine();

            Array.Sort(a);
            Console.WriteLine("\nSorted num is: ");
            foreach (int i in a)
                Console.Write(i + " ");

            Console.WriteLine();

        }
    }
}