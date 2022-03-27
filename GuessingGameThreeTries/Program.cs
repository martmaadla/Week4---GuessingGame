using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm genereerib juhusliku numbri (1-10);
            //Kasutaja peab selle numbri ära arvama;
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset ja kui kasutaja ei ole suutnud kolme katsega nr. arvata, siis mängu võidab arvuti;
            //programm genereerib juhusliku numbri ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            Console.WriteLine(cpuNumber);

            int i = 0; 

            while (i < 3 ) 

            {
                Console.Write("Arva ära number 1 kuni 10, sinul on 3 katset:");
                int Juhunr = Convert.ToInt32(Console.ReadLine());

                if (Juhunr == cpuNumber)
                {
                    Console.WriteLine("Jeppii sinu võit!");
                    break;
                }
                else
                {
                    i++; //i = i + 1 == i++;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud.");
                } 
            }
            
            if (i > 1)
            {
                Console.WriteLine($"Õige number oli " + cpuNumber);
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
