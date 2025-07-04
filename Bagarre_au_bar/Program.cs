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
                new GerardMince(),
                new GrosGerard(),
                new JohnnyDeFeu(),
                new JohnnyCadillac()
            };

            Console.WriteLine(" BIENVENUE AU BAR DE LA BAGARRE ! ");
            Console.WriteLine("\nQue voulez-vous faire ?");
            Console.WriteLine("1. Duel 1 vs 1");
            Console.WriteLine("2. Tournoi (4 combattants)");
            Console.Write("Votre choix (1-2): ");

            int choixMode = LireChoix(1, 2);

            if (choixMode == 1)
            {
                // MODE 1V1
                LancerDuel(combattants);
            }
            else
            {
                // MODE TOURNOI
                LancerTournoi(combattants);
            }

            Console.WriteLine("\nMerci d'avoir joué ! Appuyez sur une touche pour quitter...");
            Console.ReadKey();
        }

        static void LancerDuel(List<Ivrogne> combattants)
        {
            // === CHOIX DU PREMIER COMBATTANT ===
            Console.WriteLine("=== CHOIX DU PREMIER COMBATTANT ===");
            AfficherCombattants(combattants);
            Console.Write($"Choisissez le premier combattant (1-{combattants.Count}): ");

            int choix1 = LireChoix(1, combattants.Count);
            Ivrogne combattant1 = combattants[choix1 - 1];

            // Créer la liste des combattants restants pour le choix 2
            List<Ivrogne> combattantsRestants = new List<Ivrogne>(combattants);
            combattantsRestants.RemoveAt(choix1 - 1);

            Console.WriteLine($"\nPremier combattant choisi : {combattant1.Nom}");

            // === CHOIX DU DEUXIÈME COMBATTANT ===
            Console.WriteLine("\n=== CHOIX DU DEUXIÈME COMBATTANT ===");
            AfficherCombattants(combattantsRestants);
            Console.Write($"Choisissez le deuxième combattant (1-{combattantsRestants.Count}): ");

            int choix2 = LireChoix(1, combattantsRestants.Count);
            Ivrogne combattant2 = combattantsRestants[choix2 - 1];

            Console.WriteLine($"\nDeuxième combattant choisi : {combattant2.Nom}");
            Console.WriteLine($"\n{combattant1.Nom} CONTRE {combattant2.Nom} !");
            Console.WriteLine("\nAppuyez sur une touche pour commencer le combat...");
            Console.ReadKey();

            // === COMBAT ===
            Ivrogne.Duel(combattant1, combattant2);
        }

        static void LancerTournoi(List<Ivrogne> combattants)
        {
            // Sélection des 4 combattants
            List<Ivrogne> combattantsTournoi = TournoiService.ChoisirCombattantsTournoi(combattants);

            Console.WriteLine("\nAppuyez sur une touche pour lancer le tournoi...");
            Console.ReadKey();

            // Lancement du tournoi
            TournoiService.LancerTournoi(combattantsTournoi);
        }

        // Affiche tous les combattants disponibles
        static void AfficherCombattants(List<Ivrogne> combattants)
        {
            for (int i = 0; i < combattants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {combattants[i].Nom}");
            }
        }

        // Lit un choix utilisateur sécurisé
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
