using System;
using System.Collections.Generic;

namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // "Joueur" à rajouter ici
            List<Ivrogne> combattants = new List<Ivrogne>
            {
                new LeRenaud(),
                new GerardMince(),
                new GrosGerard()
            };

            Console.WriteLine("=== CHOIX DU PREMIER COMBATTANT ===");
            AfficherCombattants(combattants);
            Console.Write("Choisissez le premier combattant (1-3): ");

            int choix1 = LireChoix(1, 3);
            Ivrogne combattant1 = combattants[choix1 - 1];

            List<Ivrogne> combattantsRestants = new List<Ivrogne>(combattants);

            combattantsRestants.RemoveAt(choix1 - 1);

            Console.WriteLine($"\nPremier combattant choisi: {combattant1.Nom}");
            Console.WriteLine("\n=== CHOIX DU DEUXIÈME COMBATTANT ===");

            AfficherCombattantsRestants(combattantsRestants);
            Console.Write("Choisissez le deuxième combattant (1-2): ");

            int choix2 = LireChoix(1, 2);
            Ivrogne combattant2 = combattantsRestants[choix2 - 1];

            Console.WriteLine($"\nDeuxième combattant choisi: {combattant2.Nom}");
            Console.WriteLine($"\n{combattant1} CONTRE {combattant2} !");
            Console.WriteLine("\nAppuyez sur une touche pour commencer le combat...");
            Console.ReadKey();

            Ivrogne.Duel(combattant1, combattant2);

            Console.ReadKey();
        }

        static void AfficherCombattants(List<Ivrogne> combattants)
        {
            for (int i = 0; i < combattants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {combattants[i].Nom}");
            }
        }

        static void AfficherCombattantsRestants(List<Ivrogne> combattants)
        {
            for (int i = 0; i < combattants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {combattants[i].Nom}");
            }
        }

        static int LireChoix(int min, int max)
        {
            int choix;
            while (!int.TryParse(Console.ReadLine(), out choix) || choix < min || choix > max)
            {
                Console.Write($"Choix invalide ! Entrez un nombre entre {min} et {max}: ");
            }
            return choix;
        }
    }
}
