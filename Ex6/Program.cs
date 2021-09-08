using System;

namespace Ex6
{
    //Be användaren gissa ett tal mellan 1-21
    //Skapa ett slumptal mellan 1-21 (Se Object Browser Random, Random.Next(1,21) och MSDN)
    //Om användaren gissat rätt: skriv ut Grattis!
    //Annars fortsätt be användaren gissa

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Gissa på ett tal mellan 1-21");
            while (true)
            {

                string siffror = Console.ReadLine();

                Random rnd = new Random();

                string[] SiffrorMellan1_21 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                int sIndex = rnd.Next(SiffrorMellan1_21.Length);
                Console.WriteLine("Rätt svar: " + SiffrorMellan1_21[sIndex]);

                if (siffror == SiffrorMellan1_21[sIndex])
                {
                    break;
                }
                Console.WriteLine("Fortsätt gissa ;)");

            }
            Console.WriteLine("Grattis!");

        }
    }
}
