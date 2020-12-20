using System;
using System.Linq;
using System.Collections.Generic;

namespace BasicStackOperations
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
            Stack<int> stackOfInt = new Stack<int>(numbers);




            for (int i = 0; i < s; i++)
            {
                stackOfInt.Pop();
                if (stackOfInt.Count == 0)
                {
                    Console.WriteLine("0");
                    return;
                }
            }

            int smallest = stackOfInt.Peek();
            while (stackOfInt.Count > 0)
            {

            
                int current = stackOfInt.Peek();


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
                    stackOfInt.Pop();
                }
            }


            Console.WriteLine(smallest);


        }
    }
}
