using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.GausTrick
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                result.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }
            
            if (numbers.Count % 2 == 1)
            {
                Console.WriteLine($"{string.Join(" ", result)} {numbers[numbers.Count / 2]} ");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", result)}");
            }






        }
    }
}
