using System;

namespace mira_bd
{
    class Loop1
    {
        public static void Main(string[] args)
        {
            int[] a = new int[5] { 'a', 'b', 'c', 'd', 'e' }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            foreach (string i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
