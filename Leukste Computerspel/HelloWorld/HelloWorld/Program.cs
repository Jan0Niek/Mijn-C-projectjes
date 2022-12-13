using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey daar makker! ");
            Console.WriteLine("Wat is jouw favoriete computerspel? ");
            string spel = Console.ReadLine();
            Console.WriteLine("Dat spel, " + spel + ", is inderdaad heel leuk!");

            Console.ReadLine();
        }
    }
}