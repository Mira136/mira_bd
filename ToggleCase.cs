using System;

namespace mira_bd
{
    class ToggleCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();
            string result = "";

            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    result += char.ToLower(c);
                else
                    result += char.ToUpper(c);
            }

            Console.WriteLine("Toggle Case: " + result);
            Console.ReadLine();
        }
    }
}
