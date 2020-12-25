using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[i] = new int[rowData.Length];
                for (int x = 0; x < rowData.Length; x++)
                {
                    matrix[i][x] = rowData[x];
                }
            }
            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {

                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix[row].Length)
                    {
                        matrix[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row >= 0 && col >= 0 && row < matrix.GetLength(0) && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }







                command = Console.ReadLine().Split();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
              
            }





        }
    }
}
