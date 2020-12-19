using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Stack<char> reversed = new Stack<char>(input);

            while (true && reversed.Count > 0)
            {
                Console.Write(reversed.Pop());
            }




        }
    }
}
