public static class ListeMenuStructure
{
    public static void AfficherListePersonnages()
    {
        bool ListeLance = true;

        while (ListeLance)
        {
            ListeAffichage.AfficherListeMenu();
            string choixutilisateur = Console.ReadLine();

            switch (choixutilisateur)
            {
                case "0":
                    ListeLance = false;
                    break;

                case "1": // Le Gérard
                    ListePersoLeGerard.AfficherBioLeGerard();
                    Console.ReadKey();
                    break;

                case "2": // Le Renaud
                    ListePersoLeRenaud.AfficherBioLeRenaud();
                    Console.ReadKey();
                    break;

                case "3": // Le Johnny
                    ListePersoLeJohnny.AfficherBioLeJohnny();
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Choix invalide. Appuyez sur une touche pour réessayer.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

