using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimunElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stackOfInt = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        stackOfInt.Push(input[1]);
                        break;
                    case 2:
                        if (stackOfInt.Count > 0)
                        {
                            stackOfInt.Pop();
                        }
                        
                        break;
                    case 3:
                        if (stackOfInt.Count > 0)
                        {
                            Console.WriteLine(stackOfInt.Max(a => a));
                        }
                       
                        break;
                    case 4:
                        if (stackOfInt.Count > 0)
                        {
                            Console.WriteLine(stackOfInt.Min(a => a));
                        }
                        break;

                    default:
                        break;
                }



            }
            Console.WriteLine(string.Join(", ", stackOfInt));
        }
    }
}
