using System;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {


            string text = Console.ReadLine();
            MiddleChar(text);




        }
        static void MiddleChar(string a)
        {
            if (a.Length % 2 == 0)
            {
                Console.WriteLine(a[(a.Length / 2)-1].ToString() + a[a.Length / 2].ToString());
            }
            else
            {
                Console.WriteLine(a[a.Length/2]);
            }
        }
    }
}
