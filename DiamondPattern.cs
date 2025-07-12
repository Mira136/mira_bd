using System;

namespace mira_bd
{ 
class DiamondPattern
{
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write(new string(' ', 5 - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }

            for (int i = 5 - 1; i >= 1; i--)
            {
                Console.Write(new string(' ', 5 - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
}
