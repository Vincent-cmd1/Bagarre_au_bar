public class MenuStructure
{
    public static void AfficherMenu()
    {
        bool ProgrammeLance = true;
        while (ProgrammeLance)
        {
            MenuAffichage.AfficherMenu();
            string choixutilisateur = Console.ReadLine();

            switch (choixutilisateur)
            {
                case "0":
                    ProgrammeLance = false;
                    MenuQuitter.AfficherQuitter();
                    break;

                case "1":
                    DuelService.LancerDuel();
                    Console.ReadKey();
                    break;

                /*case "2":
                    TournoiService.LancerTournoi(program.combattants);
                    Console.ReadKey();
                    break;*/

                case "4":
                    ListeMenuStructure.AfficherListePersonnages();
                    Console.ReadKey();
                    break;

                case "6":
                    Regles.AfficherRegles();
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
