using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);


        }
        static void Grades (double result)
        {
            if (result >= 2 && result < 3)
            {
                Console.WriteLine("Fail");
            }
            else if (result >= 3 && result < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (result >= 3.50 && result < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (result >= 4.50 && result < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else if (result >= 5.50 && result <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
