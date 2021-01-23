using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> values = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (values.ContainsKey(array[i]))
                {
                    values[array[i]]++;
                }
                else
                {
                    values.Add(array[i], 1);
                }

            }

            foreach (var num in values)
            {

                Console.WriteLine($"{num.Key} - {num.Value} times");
            }





        }
    }
}
