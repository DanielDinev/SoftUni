using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum1 = 0;
            int sum2 = 0;


            while (player1.Count > 0 && player2.Count > 0)
            {

                if (player1[0] > player2[0])
                {
                    player1.Add(player1[0]);
                    player1.Add(player2[0]);
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }
                else if (player2[0] > player1[0])
                {
                    player2.Add(player2[0]);
                    player2.Add(player1[0]);
                    player2.RemoveAt(0);
                    player1.RemoveAt(0);
                }
                else
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);

                }
            }

            if (player1.Count > player2.Count)
            {
                for (int i = 0; i < player1.Count; i++)
                {
                    sum1 += player1[i];
                }
                Console.WriteLine($"First player wins! Sum: {sum1}");
            }
            else
            {
                for (int i = 0; i < player2.Count; i++)
                {
                    sum2 += player2[i];
                }
                Console.WriteLine($"Second player wins! Sum: {sum2}");
            }


        }
    }
}
