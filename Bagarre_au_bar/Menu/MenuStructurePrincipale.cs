using System;

public class Menu
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
                    break;

                case "2":
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "6":
                    Regles.AfficherRegles();
                    Console.ReadKey();
                    break;

            }
        }
    }
}
