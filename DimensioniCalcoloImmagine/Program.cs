using System;

namespace DimensioniCalcoloImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione1;
            int dimensione2;
            int operazione;
            string bit;

            Console.WriteLine("inserisci la prima dimensione dell'immagine");
            dimensione1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la seconda dimensione dell'immagine");
            dimensione2 = Convert.ToInt32(Console.ReadLine());        
            
            Console.WriteLine("Inserisci da quanti bit è formata l'immagine");
            bit = (Console.ReadLine());

            switch (bit)
            {
                case "8":
                    operazione = (dimensione1 * dimensione2)  / 1024;
                    Console.WriteLine($"Il peso dell'immagine è: {operazione}KB");
                    break;

                case "16":
                    operazione = (dimensione1 * dimensione2) * 2 / 1024;
                    Console.WriteLine($"Il peso dell'immagine è: {operazione}KB");
                    break;

                case "24":
                    operazione = (dimensione1 * dimensione2) * 3 / 1024;
                    Console.WriteLine($"Il peso dell'immagine è: {operazione}KB");
                    break;
            }
            Console.ReadKey();


        }
    }
}
