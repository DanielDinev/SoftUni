using System;
using System.Collections.Generic;
using System.Linq;

namespace SetOfElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] setSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < setSize[0]; i++)
            {
                int input = int.Parse(Console.ReadLine());
                n.Add(input);


            }
            for (int i = 0; i < setSize[1]; i++)
            {

                int input = int.Parse(Console.ReadLine());
                m.Add(input);

            }

            n.IntersectWith(m);

            Console.WriteLine(string.Join(" ", n));





        }
    }
}
