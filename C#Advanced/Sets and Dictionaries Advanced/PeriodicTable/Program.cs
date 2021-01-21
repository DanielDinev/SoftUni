using System;
using System.Collections.Generic;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedSet<string> chemCompounds = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split();

                for (int x = 0; x < array.Length; x++)
                {
                    chemCompounds.Add(array[x]);
                }

            }

            Console.WriteLine(string.Join(" ", chemCompounds));







        }
    }
}
