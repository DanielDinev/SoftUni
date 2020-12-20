using System;
using System.Linq;
using System.Collections.Generic;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] box = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(box);
            int capacity = int.Parse(Console.ReadLine());
            int rackCount = 1;
            int sum = 0;
            int currentRackCap = capacity;
            while (clothes.Count > 0)
            {
                
                int currentItem = clothes.Peek();
                int test = currentItem + sum;
                if (test <= capacity)
                {
                    sum += currentItem;
                    clothes.Pop();
                }
                else
                {
                    sum = 0;
                    rackCount++;
                }
             



            }

            Console.WriteLine(rackCount);



        }
    }
}
