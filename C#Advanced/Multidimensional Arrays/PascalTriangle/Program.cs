using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            long [][] jaggedArray = new long[n][];
           
            
            if (n == 1)
            {
                jaggedArray[0] = new long[] { 1 };
            }
            else
            {

                jaggedArray[0] = new long[] { 1 };
                jaggedArray[1] = new long[] { 1, 1 };
                for (int i = 2; i < n; i++)
                {
                    jaggedArray[i] = new long[i + 1];
                    jaggedArray[i][0] = 1;
                    jaggedArray[i][jaggedArray[i].Length - 1] = 1;
                    for (int x = 1; x < jaggedArray[i].Length - 1; x++)
                    {
                        jaggedArray[i][x] = jaggedArray[i - 1][x] + jaggedArray[i - 1][x - 1];
                    }
                }
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }



        }
    }
}
