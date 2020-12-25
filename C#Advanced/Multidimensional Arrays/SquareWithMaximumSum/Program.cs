using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int sizeRows = matrixSize[0];
            int sizeCols = matrixSize[1];


            int[,] matrix = new int[sizeRows, sizeCols];

            for (int i = 0; i < sizeRows; i++)
            {
                int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int x = 0; x < sizeCols; x++)
                {
                    matrix[i, x] = array[x];
                }
            }
            int[] firstHalf = new int[2];
            int[] secondHalf = new int[2];
            int maxSum = int.MinValue;
            int currentSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int i = 0; i < sizeRows -1; i++)
            {

                for (int x = 0; x < sizeCols - 1; x++)
                {
                    currentSum = matrix[i, x] + matrix[i, x + 1] + matrix[i + 1, x] + matrix[i + 1, x + 1];
                  
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                       maxRow = i;
                       maxCol = x;
                    }
                    else
                    {
                        currentSum = 0;
                    }
                }
                
            }

            Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
            Console.WriteLine(matrix[maxRow+1, maxCol] + " " + matrix[maxRow+1, maxCol + 1]);
            Console.WriteLine(maxSum);




        }


        
    }
}
