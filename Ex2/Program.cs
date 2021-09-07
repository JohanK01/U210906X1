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

      
            //skriver ut det största ordet
            int length = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (words[length].Length < words[i].Length)
                {
                    length = i;
                }
            }
            Console.Write(words[length]);
            
        }
    }
}
