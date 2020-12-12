using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool a = false;

            for (int i = 0; i < array.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;
                for (int x = 0; x < i; x++)
                {
                    leftSum += array[x];
                }
                for (int z = i + 1; z < array.Length; z++)
                {
                    rightSum += array[z];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    a = true;
                }
            }

            if (a == false)
            {
                Console.WriteLine("no");
            }





        }
    }
}
