using System;
using System.Collections.Generic;

namespace CharRange
{
    class Program
    {
        static void Main(string[] args)
        {

            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharsBetween(a, b);


        }
        
        static void CharsBetween (char a, char b)
        {
            char current;
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    current = (char)i;
                    Console.Write(current + " ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    current = (char)i;
                    Console.Write(current + " ");
                }
            }
        }
    }
}
