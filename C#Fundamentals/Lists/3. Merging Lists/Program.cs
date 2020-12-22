using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> num1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> num2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int count = 0;
            int broqch = 0;
            int broqch2 = 0;
            bool num1or2 = false;

            if (num1.Count > num2.Count)
            {
                count = num2.Count;
                num1or2 = true;
            }
            else
            {
                count = num1.Count;
            }

            for (int i = 0; i < count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    result.Add(num1[broqch]);
                    broqch++;
                }
                else
                {
                    result.Add(num2[broqch2]);

                    broqch2++;

                }


            }

            Console.Write(string.Join(" ", result));

            if (num1or2 == true)
            {
                for (int i = num2.Count; i < num1.Count; i++)
                    
                {
                    Console.Write(" " + num1[i]);
                }
            }
            else
            {
                for (int i = num1.Count; i < num2.Count; i++)

                {
                    Console.Write(" " + num2[i]);
                }
            }

            
        }
    }
}
