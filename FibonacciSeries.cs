using System;

namespace mira_bd
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;

            Console.Write("Fibonacci Series: ");
            for (int i = 1; i <= 11; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }

            Console.ReadLine();
        }
    }
}
