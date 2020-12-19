using System;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(Sum(int1, int2), int3));



        }
        static int Sum(int int1, int int2)
        {
            return int1 + int2;
        }
        static double Substract(int sum, int c)
        {
            return sum - c;
        }


    }
}
