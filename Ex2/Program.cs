using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();
            string[] words = mening.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"{word}");
            }
        }
    }
}
