using System;

namespace mira_bd
{
    class NameWithPrefix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Gender (M/F): ");
            char gender = Convert.ToChar(Console.ReadLine().ToUpper());

            if (gender == 'M')
                Console.WriteLine("Mr. " + name);
            else if (gender == 'F')
                Console.WriteLine("Ms. " + name);
            else
                Console.WriteLine("Invalid Gender");

            Console.ReadLine();
        }
    }
}



