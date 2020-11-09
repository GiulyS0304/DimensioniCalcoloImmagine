using System;

namespace DimensioniCalcoloImmagine
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensione1;
            int dimensione2;
            
            Console.WriteLine("inserisci la prima dimensione");
            dimensione1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserisci la seconda dimensione");
            dimensione2 = Convert.ToInt32(Console.ReadLine());

            int pixel = (dimensione1 * dimensione2) *3 / 1024; 
            Console.WriteLine($"Il peso dell'immagine è {pixel}KB");
            Console.ReadKey();

           
        }
    }
}
