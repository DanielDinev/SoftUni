using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = Console.ReadLine();
            bool left = false;


            while (number1 != "END")
            {


                for (int i = 0; i < number1.Length / 2; i++)
                {
                    if (number1[i] == number1[(number1.Length - 1) - i])
                    {
                        left = true;
                    }
                    else
                    {
                        left = false;
                        break;
                    }
                }


                if (left == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                number1 = Console.ReadLine();
            }

        }
    }
}
