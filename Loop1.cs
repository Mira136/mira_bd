﻿using System;

namespace mira_bd
{
    class Array
    {
        public static void Main(string[] args)
        {
            int[] a = { "a", "b", "c", "d", "e" };

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            /*foreach (string i in a)
            {
                Console.WriteLine(i);
            }*/
        }
    }
}
