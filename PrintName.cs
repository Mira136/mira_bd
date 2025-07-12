using System;

namespace mira_bd
{
    class PrintName
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Output: " + name);
            Console.ReadLine();
        }
    }
}
