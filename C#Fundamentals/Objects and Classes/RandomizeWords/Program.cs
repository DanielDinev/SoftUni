using System;
using System.Collections.Generic;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(Console.ReadLine().Split());

            Random rnd = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                var randomindex = rnd.Next(0, words.Count);
                var randomEl = words[randomindex];
                var el = words[i];
                words[randomindex] = el;
                words[i] = randomEl;

            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            







        }
    }
}
