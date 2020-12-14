using System;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();


            for (int i = 0; i < input.Length; i++)
            {
                for (int x = 0; x < input[i].Length; x++)
                {
                    result.Append(input[i]);
                }
            }
            Console.WriteLine(result);



        }
    }
}
