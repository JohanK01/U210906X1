﻿using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();

            string[] orden = new string [99999];
            int ordmangd = 0;

            for (int i = 0; i < mening.Length; i++)
            {
                if (mening[i] == ' ')
                {
                    ordmangd++;
                }
                else
                {
                    orden[ordmangd] += mening[i];
                }
            }
            ordmangd++;
            Console.WriteLine(ordmangd);


        }
    }
}
