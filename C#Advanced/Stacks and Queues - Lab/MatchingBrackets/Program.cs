using System;
using System.Collections;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<int> openingBracket = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBracket.Push(i);
                }
                else if (input[i] == ')')
                {
                    int indexOfClosing = i;
                    int leftIndex = openingBracket.Pop();
                    string subString = input.Substring(leftIndex, indexOfClosing - leftIndex + 1);
                    Console.WriteLine(subString);

                }


            }


        }
    }
}
