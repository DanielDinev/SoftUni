using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            

            Triangle(n);
        }

        static void Triangle(int n)
        {
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = i + 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int x = 0; x < i + 1; x++)
                {
                    Console.Write(numbers[x] + " ");

                }
                Console.WriteLine();
            }
            for (int i =n-1; i >= 0; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(numbers[x] + " ");
                }
                Console.WriteLine();
            }
        }





    }
}
