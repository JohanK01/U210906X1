using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många tal du vill ha");
            int antal = Convert.ToInt32(Console.ReadLine());

            int[] sifferbok = new int[antal];
            int temp;
            for (int i = 0; i < antal; i++)
            {
                Console.Write("Skriv en siffra: ");
                sifferbok[i] = Convert.ToInt32(Console.ReadLine());
            }

         
            for (int j = 0; j < sifferbok.Length - 1; j++)
            {
                for (int i = 0; i < sifferbok.Length - 1; i++)
                {
                    if (sifferbok[i] > sifferbok[i + 1])
                    {
                        temp = sifferbok[i + 1];
                        sifferbok[i + 1] = sifferbok[i];
                        sifferbok[i] = temp;
                    }
                }
            }
            Console.WriteLine("färdig");
            foreach (int p in sifferbok)
            {
                Console.Write(p + " ");
            }
        }
    }
}
