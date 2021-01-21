using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> numbers = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (numbers.ContainsKey(input))
                {
                    numbers[input]++;
                }
                else
                {
                    numbers.Add(input, 1);
                }

            }

            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }






        }
    }
}
