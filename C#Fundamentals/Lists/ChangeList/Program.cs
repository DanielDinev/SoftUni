using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    nums.RemoveAll(n => n==int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    nums.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }



                input = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", nums));



        }
    }
}
