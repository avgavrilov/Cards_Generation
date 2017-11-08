using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards_Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string y = "s";
            string[] K = new string[36];
            string[] M = { "♠", "♥", "♣", "♦" };
            string[] V = { "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    K[j * 9 + i] = V[i] + M[j];
                }
            }

            for (int i = 0; i < 36; i++)
            {
                Console.Write("K[{0}] = {1} ", i, K[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                for (int i = 0; i < 36; i++)
                {
                    int a = rand.Next(1, 36);
                    int b = rand.Next(1, 36);
                    string c = K[a];
                    K[a] = K[b];
                    K[b] = c;
                }
                for (int i = 0; i < 36; i++)
                {
                    Console.Write("{0} ", K[i]);
                }
                Console.WriteLine("перемешать?");
                y = Console.ReadLine();
            }
            while (y != "s");

            string[] T = new string[32];
            int f = 0;
            for (int i = 0; i < 36; i++)
            {
                if (!K[i].StartsWith("A"))
                {
                    T[f] = K[i];
                    f++;
                }
            }
            K = T;
            for (int i = 0; i < 32; i++)
            {
                Console.Write("{0} ", K[i]);
            }
            Console.ReadKey();


        }
    }
}
