public static class TournoiService
{
    public static void LancerTournoi()
    {
        // Liste des combattants disponibles
        List<Ivrogne> combattants = CombattantsManager.ObtenirTousLesCombattants();

        Console.Clear();

        // Sélectionner 4 combattants parmi tous
        List<Ivrogne> combattantsSelectionnes = ChoisirCombattantsTournoi(combattants);

        Console.WriteLine("\n=== DÉBUT DU TOURNOI ===");
        Console.WriteLine($"Participants : {string.Join(", ", combattantsSelectionnes.Select(c => c.Nom))}");
        Console.WriteLine("\nQue le meilleur ivrogne gagne !");
        Console.WriteLine("\nAppuyez sur ENTRÉE pour commencer...");
        Console.ReadLine();

        // Réinitialiser tous les combattants
        foreach (var combattant in combattantsSelectionnes)
        {
            combattant.Reinitialiser();
        }

        // DEMI-FINALES
        Console.WriteLine("\n=== DEMI-FINALES ===");

        Console.WriteLine("\n--- DEMI-FINALE 1 ---");
        Ivrogne finaliste1 = Ivrogne.CombatRapide(combattantsSelectionnes[0], combattantsSelectionnes[1]);
        Ivrogne perdant1 = combattantsSelectionnes[0].EstEnVie() ? combattantsSelectionnes[1] : combattantsSelectionnes[0];

        Console.WriteLine("\nAppuyez sur ENTRÉE pour continuer...");
        Console.ReadLine();

        Console.WriteLine("\n--- DEMI-FINALE 2 ---");
        Ivrogne finaliste2 = Ivrogne.CombatRapide(combattantsSelectionnes[2], combattantsSelectionnes[3]);
        Ivrogne perdant2 = combattantsSelectionnes[2].EstEnVie() ? combattantsSelectionnes[3] : combattantsSelectionnes[2];

        Console.WriteLine("\nAppuyez sur ENTRÉE pour continuer...");
        Console.ReadLine();

        // MATCH POUR LA 3ÈME PLACE
        Console.WriteLine("\n=== MATCH POUR LA 3ÈME PLACE ===");
        Console.WriteLine("Les perdants des demi-finales s'affrontent !");

        // Réinitialiser les perdants
        perdant1.Reinitialiser();
        perdant2.Reinitialiser();

        Ivrogne troisieme = Ivrogne.CombatRapide(perdant1, perdant2);
        Ivrogne quatrieme = perdant1.EstEnVie() ? perdant2 : perdant1;

        Console.WriteLine("\nAppuyez sur ENTRÉE pour continuer...");
        Console.ReadLine();

        // FINALE
        Console.WriteLine("\n=== GRANDE FINALE ===");
        Console.WriteLine("L'heure de vérité a sonné !");

        // Réinitialiser les finalistes
        finaliste1.Reinitialiser();
        finaliste2.Reinitialiser();

        Ivrogne champion = Ivrogne.CombatRapide(finaliste1, finaliste2);
        Ivrogne deuxieme = finaliste1.EstEnVie() ? finaliste2 : finaliste1;

        Console.WriteLine("\nAppuyez sur ENTRÉE pour voir le podium...");
        Console.ReadLine();

        // PODIUM FINAL
        Console.WriteLine("\n" + new string('=', 60));
        Console.WriteLine("          PODIUM FINAL DU TOURNOI          ");
        Console.WriteLine(new string('=', 60));

        Console.WriteLine($"\n1ER PLACE : {champion.Nom}");
        Console.WriteLine("   \"Un vrai bagarreur de bar, celui-là !\"");

        Console.WriteLine($"\n2ÈME PLACE : {deuxieme.Nom}");
        Console.WriteLine("   \"Presque champion, la prochaine fois c'est la bonne !\"");

        Console.WriteLine($"\n3ÈME PLACE : {troisieme.Nom}");
        Console.WriteLine("   \"Sur le podium ! Une bière offerte !\"");

        Console.WriteLine($"\n4ÈME PLACE : {quatrieme.Nom}");
        Console.WriteLine("   \"Tu nettoies les verres ce soir mon pote !\"");

        Console.WriteLine("\n" + new string('=', 60));
        Console.WriteLine("        MERCI D'AVOIR PARTICIPÉ !");
        Console.WriteLine("      Le bar est maintenant sens dessus dessous !");
        Console.WriteLine(new string('=', 60));

        Console.WriteLine("\nAppuyez sur ENTRÉE pour retourner au menu...");
    }

    public static List<Ivrogne> ChoisirCombattantsTournoi(List<Ivrogne> tousLesCombattants)
    {
        Console.WriteLine("\n=== SÉLECTION DES COMBATTANTS ===");
        Console.WriteLine($"Choisissez 4 combattants parmi les {tousLesCombattants.Count} disponibles :");

        for (int i = 0; i < tousLesCombattants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tousLesCombattants[i].Nom}");
        }

        List<Ivrogne> combattantsSelectionnes = new List<Ivrogne>();

        for (int i = 0; i < 4; i++)
        {
            Console.Write($"\nChoisissez le combattant {i + 1} (1-{tousLesCombattants.Count}): ");
            int choix = LireChoix(1, tousLesCombattants.Count);

            Ivrogne combattantChoisi = tousLesCombattants[choix - 1];

            if (combattantsSelectionnes.Contains(combattantChoisi))
            {
                Console.WriteLine("Ce combattant est déjà sélectionné ! Choisissez-en un autre.");
                i--; // Recommencer cette sélection
            }
            else
            {
                combattantsSelectionnes.Add(combattantChoisi);
                Console.WriteLine($" {combattantChoisi.Nom} sélectionné !");
            }
        }

        return combattantsSelectionnes;
    }

    private static int LireChoix(int min, int max)
    {
        int choix;
        while (!int.TryParse(Console.ReadLine(), out choix) || choix < min || choix > max)
        {
            Console.Write($"Choix invalide. Entrez un nombre entre {min} et {max}: ");
        }
        return choix;
    }
}
