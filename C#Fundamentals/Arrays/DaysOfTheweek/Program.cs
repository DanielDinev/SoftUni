using System;

namespace DaysOfTheweek
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] days = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day >= 0 && day <=7)
            {
                Console.WriteLine(days[day]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
