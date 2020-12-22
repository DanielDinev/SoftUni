using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                if (input[0] == "Add")
                {
                    nums.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    if (int.Parse(input[2]) < nums.Count && int.Parse(input[2])>=0)
                    {
                        nums.Insert(int.Parse(input[2]), int.Parse(input[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) < nums.Count && int.Parse(input[1]) >= 0)
                    {
                        nums.RemoveAt(int.Parse(input[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (input[1] == "left")
                {
                    if (int.Parse(input[2]) > 0)
                    {

                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            nums.Add(nums[0]);
                            nums.Remove(nums[0]);


                        }




                    }

                }
                else if (input[1] == "right")
                {
                    if (int.Parse(input[2]) > 0)
                    {

                        for (int i = 0; i < int.Parse(input[2]); i++)
                        {
                            int last = nums[nums.Count - 1];
                            nums.Remove(nums[nums.Count - 1]);
                            nums.Insert(0, last);


                        }



                    }



                }


                input = Console.ReadLine().Split();
            }


            Console.WriteLine(string.Join(" ", nums));




        }
    }
}
