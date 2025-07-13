using System;

namespace mira_bd
{
    class Array
    {
        public static void Main(string[] args)
        {
            int[] num = { 10 , 20 , 30 , 40 , 50 };

            Console.WriteLine("Array elements:");

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

           /*foreach (int i in num)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
