using System;

namespace SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                string chars = Console.ReadLine();
                for (int x = 0; x < chars.Length; x++)
                {
                    matrix[i, x] = chars[x];
                }
            }
            char inputChar = char.Parse(Console.ReadLine());
           
            for (int i = 0; i < n; i++)
            {
               
                for (int x = 0; x < n; x++)
                {
                    if (inputChar == matrix[i, x])
                    {
                        Console.WriteLine($"({i}, {x})");
                        
                        return;
                    }
                }
            }

            Console.WriteLine($"{inputChar} does not occur in the matrix");


        }
    }
}
