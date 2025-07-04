public class MenuAffichage
{
    public static void AfficherMenu()
    {
        Console.Clear();
        Console.WriteLine("╔══════════════════════════════╗");
        Console.WriteLine("║        BAGARRE AU BAR        ║");
        Console.WriteLine("╠══════════════════════════════╣");
        Console.WriteLine("║ 1. Lancer une bagarre        ║");
        Console.WriteLine("║ 2. Créer un bagarreur        ║");
        Console.WriteLine("║ 3. Supprimer un bagarreur    ║");
        Console.WriteLine("║ 4. Afficher les bagarreurs   ║");
        Console.WriteLine("║ 5. Afficher l'historique     ║");
        Console.WriteLine("║ 6. Les règles                ║");
        Console.WriteLine("║ 0. Quitter le jeu            ║");
        Console.WriteLine("╚══════════════════════════════╝");
        Console.Write("Faites votre choix (1-6) : ");
    }
}