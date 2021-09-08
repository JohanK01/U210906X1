using System;

namespace Ex5
{
    class Program
    {
        //Låt användaren mata in ett ord i taget
        //Avsluta programmet om användaren matar in AVSLUTA
        //Skriv ut din mening just nu är: skriv ut alla inmatade ord

        static void Main(string[] args)
        {
            string mening = "";
           
            while (true)
            {

                Console.WriteLine("Mata in ett ord");
                string orden = Console.ReadLine();
                if (orden == "avsluta")
                {

                    break;
                }
                mening = mening + orden + " ";

            } 
            Console.WriteLine("Alla inmatade orden är:" + mening);


        }
    }
}
