using System;
using System.Linq;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] martixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = martixSize[0];
            int cols = martixSize[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
              int[] current = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = current[col];
                }
            }
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);


        }
    }
}
