using System;

class Class1
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");
		Console.Read();

		int no;
		no = 1;
		while (no <= 10)
		{
			Console.WriteLine(no);
			no++;
		}
		for (int no = 1; no <= 10; no++)
		{
			Console.WriteLine(no);
		}
	}
}
