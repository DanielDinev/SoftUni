using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagoons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxSpace = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();



            while (input[0] != "end")
            {
                if (input.Length > 1)
                {
                    wagoons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagoons.Count; i++)
                    {
                        int freeSpace = maxSpace - wagoons[i];
                        if (int.Parse(input[0]) <= freeSpace )
                        {
                            wagoons[i] += int.Parse(input[0]);
                            break;

                        }
                    }
                }


                input = Console.ReadLine().Split();
            }

            foreach (var item in wagoons)
            {
                Console.Write(item + " ");
            }








        }
    }
}
