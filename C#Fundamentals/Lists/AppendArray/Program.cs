using System;
using System.Collections.Generic;

namespace AppendArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            for (int i = array.Length-1; i >= 0; i--)
            {
                string[] array1 = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int x = 0; x < array1.Length; x++)
                {
                    result.Add(array1[x].Trim());
                }
            }

            Console.WriteLine(string.Join(" ", result).Trim()) ;




        }
    }
}
