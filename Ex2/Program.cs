using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening");
            string mening = Console.ReadLine();
            string[] wordsArr = mening.Split(' ');
            int arrLength = wordsArr.Length;



            for (int i = 1; i < wordsArr.Length; i++)
            {
                string temp = wordsArr[i];
                int inn = i - 1;
                while (inn >= 0 && temp.Length < wordsArr[inn].Length)
                {
                    wordsArr[inn + 1] = wordsArr[inn];
                    inn--;
                }
                wordsArr[inn + 1] = temp;
            }

            for (int i = 0; i < arrLength; i++)
            {
                Console.WriteLine(wordsArr[i]);
            }
            Console.ReadLine();
        }
    }
}
