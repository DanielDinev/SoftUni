using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> result = new List<int>();

            Queue<int> queueOfint = new Queue<int>(intArray);

            while (true)
            {
                int currentItem = queueOfint.Peek();
                if (currentItem % 2 == 0)
                {
                    result.Add(queueOfint.Dequeue());
                }
                else
                {
                    queueOfint.Dequeue();
                }
                if (queueOfint.Count == 0)
                {
                    break;
                }

            }
            


         

            Console.WriteLine(string.Join(", ", result));





        }
    }
}
