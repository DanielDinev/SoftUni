using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            bool bigger = false;

            for (int i = 0; i < array.Length; i++)
            {
                bigger = false;

                for (int x = i+1; x < array.Length; x++)
                {
                    if (array[i] > array[x])
                    {
                        bigger = true;
                        break;
                    }
                    else
                    {
                        bigger = false;
                        break;
                    }
                   
                }
                if (bigger == true)
                {

                    Console.Write(array[i] + " ");
                  

                }
            }
          
                Console.WriteLine(array[array.Length - 1]);
          
               



        }
    }
}
