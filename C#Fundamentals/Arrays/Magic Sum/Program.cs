using System;
using System.Linq;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int x = i+1; x < array.Length; x++)
                {
                    if (array[i] + array[x] == num)
                    {
                        Console.WriteLine(array[i] + " " + array[x]);
                    }
                }



            }






        }
    }
}
