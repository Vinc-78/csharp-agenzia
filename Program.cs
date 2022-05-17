using System;

namespace csharp_agenzia
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {

            Villa v = new Villa("123", "Via Roma", "1546", "Napoli", 245, 5, 2, 152);
            Appartamento app1 = new Appartamento("A456", "Via Lago", "254", "Milano", 110, 4, 2);

            Agenzia prova = new Agenzia("Immobiliare srl");

            List<Immobile> result = prova.SearchImmobili("1546");

            foreach (Immobile immobile in result)
            { 
                Console.WriteLine(immobile.ToString());
                Console.WriteLine("------------------------------"); 
            }

        }


    }
}

