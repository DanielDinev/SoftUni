using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[2] == "going!")
                {
                    if (names.Contains(input[0]))
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                    else
                    {
                        names.Add(input[0]);
                    }
                }
                else
                {
                    if (names.Contains(input[0]))
                    {
                        names.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }





                
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
