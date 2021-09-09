using System;

namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in nummer");
            Int16.Parse("100");
            int[] tal = { 6, 7, 11, 4, 1, 2 };
            foreach (int i in tal)
            {
                Console.Write(i+" ");
            }
            int temp;

            for (int j = 0; j < tal.Length - 1; j++)
            {
                for (int i = 0; i < tal.Length - 1; i++)
                {
                    if (tal[i] > tal[i + 1])
                    {
                        temp = tal[i + 1];
                        tal[i + 1] = tal[i];
                        tal[i] = temp;
                    }
                }
            }
            Console.WriteLine("färdig");
            foreach (int p in tal)
            {
                Console.Write(p + " ");
            }
        }
    }
}
