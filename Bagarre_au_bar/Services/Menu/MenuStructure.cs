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
                    Console.Clear();
                    ProgrammeLance = false;
                    MenuQuitter.AfficherQuitter();
                    Console.Readkey();
                    break;

                case "1":
                    Console.Clear();
                    DuelService.LancerDuel();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "2":
                    Console.Clear();
                    TournoiService.LancerTournoi();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "4":
                    Console.Clear();
                    ListeMenuStructure.AfficherListePersonnages();
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "6":
                    Console.Clear();
                    Regles.AfficherRegles();
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
