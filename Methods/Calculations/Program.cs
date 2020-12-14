using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (type == "add")
            {
                Add(num1, num2);
            }
            else if (type == "multiply")
            {
                Multiply(num1, num2);
            }
            else if (type == "subtract")
            {
                Subtract(num1, num2);
            }
            else if (type == "divide")
            {
                divide(num1, num2);
            }

        }
        static void Add (int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void divide(int num1, int num2)
        {
            Console.WriteLine(num1 / (num2*1.0));
        }

    }
}
