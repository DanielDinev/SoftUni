using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];



            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
           Queue<int> queuefInt = new Queue<int>(numbers);




            for (int i = 0; i < s; i++)
            {
                queuefInt.Dequeue();
                if (queuefInt.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }

            int smallest = queuefInt.Peek();
            while (queuefInt.Count > 0)
            {


                int current = queuefInt.Peek();


                if (current == x)
                {
                    Console.WriteLine("true");
                    return;
                }
                else
                {
                    if (current < smallest)
                    {
                        smallest = current;
                    }
                    queuefInt.Dequeue();
                }
            }


            Console.WriteLine(smallest);




        }
    }
}
