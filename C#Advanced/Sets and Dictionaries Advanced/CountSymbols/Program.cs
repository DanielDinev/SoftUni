using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<char, int> countSymb = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (countSymb.ContainsKey(input[i]))
                {
                    countSymb[input[i]]++;
                }
                else
                {
                    countSymb.Add(input[i], 1);
                }
            }

            foreach (var charr in countSymb)
            {
                Console.WriteLine($"{charr.Key}: {charr.Value} time/s");
            }


        }
    }
}
