using System;

namespace mira_bd
{
    class Class3
    {
        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter string value:");
            str = Console.ReadLine();
            Console.WriteLine("String is:" + str);
            int no1;
            int no2;
            Console.WriteLine("Enter two numbers no1 and no2:");
            no1 = Convert.toInt32(Console.ReadLine());
            no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("First number is:" + no1);
            Console.WriteLine("Second number is:" + no2); 
        }
    }
}
/*Operators:
 * Unary : ++, --,-
 * Binary : +,-,>...
 * Ternary : ? :
 * 
 * Desicion making statement & Looping Statement
 */
