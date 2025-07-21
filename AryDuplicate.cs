using System;

namespace mira_bd
{
    class AryDuplicate
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Enter elements:");

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int count = 0;
            bool[] visited = new bool[n];

            for (int i = 0; i < n; i++)
            {
                if (visited[i])
                    continue;

                int freq = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        visited[j] = true;
                        freq++;
                    }
                }

                if (freq > 1)
                    count++;
            }

            Console.WriteLine("\nNumber of duplicate elements: " + count);
        }
    }
}
