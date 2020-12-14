using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double final = 0;

            final = Calculator(num1, op, num2);
            Console.WriteLine(final);





        }

        static double Calculator (double int1, char op, double int2)
        {
            double result = 0;
            if (op == '+')
            {
                result = int1 + int2;
                return result;
            }
            else if (op == '-')
            {
                result = int1 - int2;
                return result;
            }
            else if (op == '*')
            {
                result = int1 * int2;
                return result;
            }
           else 
            {
                result = int1 / (int2*1.0);
                return result;
            }

            
        }
    }
}
