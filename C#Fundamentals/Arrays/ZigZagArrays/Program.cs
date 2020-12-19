using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int [n];
            int[] array2 = new int [n];
            

            for (int i = 1; i <= n; i++)
            {
                int[] intLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    array1[i - 1] = intLine[1];
                    array2[i - 1] = intLine[0];
                }
                else
                {
                    array1[i - 1] = intLine[0];
                    array2[i - 1] = intLine[1];
                }

            }

            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }



        }
    }
}
