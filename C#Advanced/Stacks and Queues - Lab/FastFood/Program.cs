using System;
using System.Linq;
using System.Collections.Generic;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {

            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);
            int biggestOrder = ordersQueue.Max(a => a);
            Console.WriteLine(biggestOrder);
            while (foodQuantity > 0)
            {
                int currentOrder = ordersQueue.Peek();
                if (currentOrder <= foodQuantity)
                {
                    foodQuantity -= ordersQueue.Dequeue();

                }
                else
                {
                    break;
                }
                if (ordersQueue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }

            }
            if (ordersQueue.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", ordersQueue));
            }
          
            



        }
    }
}
