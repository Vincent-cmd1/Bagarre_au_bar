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


            // // === CHOIX DU PREMIER COMBATTANT ===
            Console.WriteLine("=== CHOIX DU PREMIER COMBATTANT ===");
            AfficherCombattants(combattants);
            Console.Write($"Choisissez le premier combattant (1-{combattants.Count}): ", combattants.Count);

            int choix1 = LireChoix(1, combattants.Count);
            Ivrogne combattant1 = combattants[choix1 - 1];

            // Créer la liste des combattants restants pour le choix 2
            List<Ivrogne> combattantsRestants = new List<Ivrogne>(combattants);
            combattantsRestants.RemoveAt(choix1 - 1);

            Console.WriteLine($"\n Premier combattant choisi : {combattant1.Nom}");


            // === CHOIX DU DEUXIÈME COMBATTANT ===
            Console.WriteLine("\n=== CHOIX DU DEUXIÈME COMBATTANT ===");
            AfficherCombattants(combattantsRestants);
            Console.Write("Choisissez le deuxième combattant (1-{0}): ", combattantsRestants.Count);

            int choix2 = LireChoix(1, combattantsRestants.Count);
            Ivrogne combattant2 = combattantsRestants[choix2 - 1];

            Console.WriteLine($"\n Deuxième combattant choisi : {combattant2.Nom}");
            Console.WriteLine($"\n {combattant1.Nom} CONTRE {combattant2.Nom} !");
            Console.WriteLine("\nAppuyez sur une touche pour commencer le combat...");
            Console.ReadKey();

            // === COMBAT ===
            Ivrogne.Duel(combattant1, combattant2);

            Console.ReadKey();
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
