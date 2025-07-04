using System;

namespace mira_bd
{
	class sum1
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter the number:1");
			//type casting
			int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the number:2");
            int b = int.Parse(Console.ReadLine());

			//string interpolation
			Console.WriteLine($"sum of {a} + {b} number is :" + (a + b));
        }
	}
}
