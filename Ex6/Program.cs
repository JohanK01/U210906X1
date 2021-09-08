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
            Random rnd = new Random();

            string[] SiffrorMellan1_21 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
            int sIndex = rnd.Next(SiffrorMellan1_21.Length);
            Console.WriteLine(SiffrorMellan1_21[sIndex]);

            //while (true)
            //{
            //    Console.WriteLine("Gissa på ett tal mellan 1-21");
            //    string siffror = Console.ReadLine();
                
            //    if (siffror == "0")
            //    {
            //        break;
            //    }


            //}
            //Console.WriteLine("Grattis!");

        }
    }
}
