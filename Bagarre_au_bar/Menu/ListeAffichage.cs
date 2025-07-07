public class ListeAffichage
{
    public static void AfficherListeMenu()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║   LISTE DES PILIERS DU BAR   ║");
        Console.WriteLine("╠══════════════════════════════╣");
        Console.WriteLine("║                              ║");
        Console.WriteLine("║ 1. Le Gérard                 ║");
        Console.WriteLine("║ 2. Le Renaud                 ║");
        Console.WriteLine("║ 3. Le Johnny                 ║");
        Console.WriteLine("║                              ║");
        Console.WriteLine("║ 0. Quitter la liste          ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.Write("Faites votre choix (1-3) : ");
    }
}