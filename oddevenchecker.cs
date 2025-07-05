using System;

namespace mira_bd
{
    class oddevenchecker
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

                Console.Read();
        }
    }
}
