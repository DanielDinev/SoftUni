using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split();
            string[] array2 = Console.ReadLine().Split();

            for (int i = 0; i < array1.Length; i++)
            {
                for (int x = 0; x < array2.Length; x++)
                {
                    if (array1[i] == array2[x])
                    {
                        Console.Write(array1[i] + " ");
                    }
                }
            }




        }
    }
}
