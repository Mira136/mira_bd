using System;

namespace mira_bd
{
    class SeparateOddEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];
            int[] evenNumbers = new int[size];
            int[] oddNumbers = new int[size];
            int evenCount = 0, oddCount = 0;

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[evenCount] = numbers[i];
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount] = numbers[i];
                    oddCount++;
                }
            }

            Console.WriteLine("\nEven numbers:");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenNumbers[i] + "  ");
            }

            Console.WriteLine("\nOdd numbers:");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddNumbers[i] + "  ");
            }

            Console.WriteLine(); 
        }
    }
}
