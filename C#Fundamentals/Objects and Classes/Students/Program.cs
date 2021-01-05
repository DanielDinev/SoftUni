using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_ClassesAndObj_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> listStud = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string [] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Student current = new Student(input[0], input[1], double.Parse(input[2]));
                listStud.Add(current);



            }

            foreach (var item in listStud.OrderByDescending(n => n.Grade))
            { 
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }

      


            
        }

    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public Student(string first, string last, double grade)
        {
            FirstName = first;
            LastName = last;
            Grade = grade;
        }





    }
    







    
}
