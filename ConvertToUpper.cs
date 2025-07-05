using System;

namespace mira_bd
{
    class ConvertToUpper
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            string upperName = name.ToUpper();

            Console.WriteLine("Name in Uppercase: " + upperName);
            Console.Read();
        }
    }
}

