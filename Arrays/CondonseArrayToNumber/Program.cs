using System;
using System.Linq;

namespace CondonseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sum = new int[array1.Length-1] ;
            int realsum = 0;

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = array1[i] + array1[i + 1];
            }
            for (int i = 0; i < sum.Length; i++)
            {
                realsum += sum[i];
            }
            Console.WriteLine(realsum);




        }
    }
}
