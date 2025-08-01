﻿using System;

namespace mira_bd
{ 
    class SeriesSum
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number: ");
            int digit = Convert.ToInt32(Console.ReadLine());

            int term = 0;
            int sum = 0;

            Console.Write("Series: ");
            for (int i = 1; i <= n; i++)
            {
                term = term * 10 + digit;
                Console.Write(term);

                if (i != n)
                    Console.Write(" + ");

                sum += term;
            }
            Console.WriteLine("\nThe Sum is: " + sum);
        }
    }
}

