using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {

            double num = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());
            double result = Power(num, pow);
            Console.WriteLine(result);



        }

        static double Power (double number, double pow)
        {
            
            double result = Math.Pow(number, pow);
            return result;
        }
    }
}
