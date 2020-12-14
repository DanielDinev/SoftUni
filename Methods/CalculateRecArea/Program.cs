using System;

namespace CalculateRecArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int result = Rectangle(width, height);
            Console.WriteLine(result);


        }

        static int Rectangle(int width, int height)
        {
            return width * height;
        }

    }
}
