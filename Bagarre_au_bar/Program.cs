using System;
using System.Collections.Generic;

namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liste des combattants disponibles
            List<Ivrogne> combattants = new List<Ivrogne>
            {
                new LeRenaudTjVivant(),
                new LeRenaudTeigne(),
                new GerardMince(),
                new GrosGerard(),
                new JohnnyDeFeu(),
                new JohnnyCadillac()
            };

            // Menu principal
            Console.WriteLine("=== BAGARRE AU BAR ===");
            Console.WriteLine("1. Combat 1v1");
            Console.WriteLine("2. Tournoi (4 combattants)");
            Console.Write("Choisissez votre mode de jeu (1-2): ");

            int choixMode = LireChoix(1, 2);

            if (choixMode == 1)
            {
                // Mode 1v1 (ton code original)
                Console.WriteLine("=== CHOIX DU PREMIER COMBATTANT ===");
                AfficherCombattants(combattants);
                Console.Write($"Choisissez le premier combattant (1-{combattants.Count}): ");

                int choix1 = LireChoix(1, combattants.Count);
                Ivrogne combattant1 = combattants[choix1 - 1];

                List<Ivrogne> combattantsRestants = new List<Ivrogne>(combattants);
                combattantsRestants.RemoveAt(choix1 - 1);

                Console.WriteLine($"\nPremier combattant choisi : {combattant1.Nom}");

                Console.WriteLine("\n=== CHOIX DU DEUXIÈME COMBATTANT ===");
                AfficherCombattants(combattantsRestants);
                Console.Write("Choisissez le deuxième combattant (1-{0}): ", combattantsRestants.Count);

                int choix2 = LireChoix(1, combattantsRestants.Count);
                Ivrogne combattant2 = combattantsRestants[choix2 - 1];

                Console.WriteLine($"\nDeuxième combattant choisi : {combattant2.Nom}");
                Console.WriteLine($"\n{combattant1.Nom} CONTRE {combattant2.Nom} !");
                Console.WriteLine("\nAppuyez sur une touche pour commencer le combat...");
                Console.ReadKey();

                Ivrogne.Duel(combattant1, combattant2);
            }
            else
            {
                // Mode Tournoi
                TournoiService.LancerTournoi(combattants);
            }

            Console.ReadKey();
        }

        static void AfficherCombattants(List<Ivrogne> combattants)
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
                Console.Write($"Choix invalide ! Entrez un nombre entre {min} et {max} : ");
            }
            return choix;
        }
    }
}
