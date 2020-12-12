using System;
using System.Linq;

namespace EvenAndOddSubstractions
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;
            int odd = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum += num[i];
                }
                else
                {
                    odd += num[i];
                }
            }
            Console.WriteLine(sum - odd);



        }
    }
}
