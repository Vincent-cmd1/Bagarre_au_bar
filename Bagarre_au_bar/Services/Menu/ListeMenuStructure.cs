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
                    Console.Clear();
                    ListePersoLeGerard.AfficherBioLeGerard();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "2": // Le Renaud
                    Console.Clear();
                    ListePersoLeRenaud.AfficherBioLeRenaud();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3": // Le Johnny
                    Console.Clear();
                    ListePersoLeJohnny.AfficherBioLeJohnny();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Choix invalide. Appuyez sur une touche pour réessayer.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
}

