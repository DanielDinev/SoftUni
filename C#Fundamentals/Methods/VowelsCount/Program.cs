using System;

namespace VowelsCount
{
    class Program
    {
       // a, e, i, o, u
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VowelsCount(text);


        }

        static void VowelsCount (string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    count++;
                }
                else if (text[i] == 'A' || text[i] == 'E' || text[i] == 'I' || text[i] == 'O' || text[i] == 'U')
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }



    }

}
