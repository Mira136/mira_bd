using System;

namespace mira_bd
{
    class Pattern2
    {
        static void Main(string[] args)
        {
            int num = 1;

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
        }
    }
}

