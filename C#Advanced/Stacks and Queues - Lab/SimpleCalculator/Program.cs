using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] input = Console.ReadLine().Split();

            Stack<string> expression = new Stack<string>(input.Reverse());
            int result = int.Parse(expression.Pop().ToString());

            while (true)
            {
                string item = expression.Pop();
                if (item == "+")
                {
                    result += int.Parse(expression.Pop());
                }
                else if (item == "-")
                {
                    result -= int.Parse(expression.Pop());
                }
                if (expression.Count == 0)
                {
                    break;
                }

            }

            Console.WriteLine(result);





        }
    }
}
