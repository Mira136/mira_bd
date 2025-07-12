using System;

namespace mira_bd
{
    class ArmstrongNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int original = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while (num > 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, digits);
                num /= 10;
            }

            if (sum == original)
                Console.WriteLine(original + " is an Armstrong number.");
            else
                Console.WriteLine(original + " is not an Armstrong number.");

            Console.ReadLine();
        }
    }
}

