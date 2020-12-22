using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else
                {
                    string[] tokens = command.Split();

                    switch (tokens[0])
                    {
                        case "Add":
                            nums.Add(int.Parse(tokens[1]));
                            break;
                        case "Remove":
                            nums.Remove(int.Parse(tokens[1]));
                            break;
                        case "RemoveAt":
                            nums.RemoveAt(int.Parse(tokens[1]));
                            break;
                        case "Insert":
                            nums.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                            break;


                        default:
                            break;
                    }




                }



            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
