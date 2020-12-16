using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Matrix(num);


        }
        static void Matrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int x = 0; x < num; x++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
