using System;
using System.Numerics;

namespace BigFactoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = n;

            for (int i = n-1; i >= 1; i--)
            {
                result *= i;
            }


            Console.WriteLine(result);

        }
    }
}
