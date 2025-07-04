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

                case "6":
                    Regles.AfficherRegles();
                    Console.ReadKey();
                    break;

                default:
                    break;
            }
        }
    }
}
