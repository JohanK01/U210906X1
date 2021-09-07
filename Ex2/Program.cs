using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();
            string[] orden = mening.Split(' ');

            foreach (var word in mening)
            {
                System.Console.WriteLine($"<{word}>");
            }
        }
    }
}
