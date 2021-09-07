using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();
            string[] words = mening.Split(' ');

            Console.WriteLine(words.Length);
            foreach (string word in words)
            {
                System.Console.WriteLine($"{word} {word.Length}");
            }




        }
    }
}
