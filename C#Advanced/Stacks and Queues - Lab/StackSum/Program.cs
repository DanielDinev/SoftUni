using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOfInt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackOfNums = new Stack<int>(arrayOfInt);

            string[] input = Console.ReadLine().Split();
            string command = input[0].ToLower();
            while (command != "end")
            {
                

                if (command == "add")
                {
                    int firstNum = int.Parse(input[1]);
                    int secondNum = int.Parse(input[2]);
                    stackOfNums.Push(firstNum);
                    stackOfNums.Push(secondNum);
                }
                else if (command == "remove")
                {
                    int numsToRemove = int.Parse(input[1]);
                    if (numsToRemove <= stackOfNums.Count)
                    {

                        for (int i = 0; i < numsToRemove; i++)
                        {
                            if (stackOfNums.Count > 0)
                            {
                                stackOfNums.Pop();
                            }

                        }
                    }

                  
                    
                }


                input = Console.ReadLine().Split();
                command = input[0].ToLower();
            }


            Console.WriteLine("Sum: " + stackOfNums.Sum());


        }
    }
}
