using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int oudgetal = 1;
            int nieuwgetal = 0;
            int nieuwergetal = 1;
            int[] reeks= {};
            for (int i = 1; i < 20; i++)
            {
                nieuwergetal = nieuwgetal + oudgetal;
                nieuwgetal= oudgetal;
                oudgetal= nieuwergetal;
                Console.WriteLine(nieuwergetal);
                reeks = new int[nieuwgetal];
            }
            Console.WriteLine(reeks);
            Console.WriteLine(reeks.Length);
            Console.ReadLine();
        }
    }
}