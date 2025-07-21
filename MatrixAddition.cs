using System;

namespace mira_bd
{
    class MatrixAddition
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];
            int[,] sumMatrix = new int[rows, cols];

            Console.WriteLine("\nEnter elements of first matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix1[{i},{j}]: ");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements of second matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix2[{i},{j}]: ");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("\nSum of the two matrices is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
