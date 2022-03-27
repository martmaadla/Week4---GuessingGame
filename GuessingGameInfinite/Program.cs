using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri (1-10);
            //Kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu;
            //programm genereerib juhusliku numbri ühe korra;


            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            int i = 0;

            while (true)
            {
                Console.WriteLine("Arva ära nr 1 kuni 10, sinul piiramatu arv katseid.");
                int Juhunr = Convert.ToInt32(Console.ReadLine());

                if (Juhunr == cpuNumber)
                {
                    Console.WriteLine("Jeppii sinu võit!");
                    break;
                }
                else
                {
                    i++; //i = i + 1 == i++;
                    Console.WriteLine($"Proovi uuesti. {i + 1} katse");
                }
                
            }
            Console.WriteLine($"Tubli kasutasid {i+1} katset. Kena päeva!");

        }
    }
}
