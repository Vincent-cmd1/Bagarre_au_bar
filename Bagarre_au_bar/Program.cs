namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LeRenaud renaud = new LeRenaud();
            LeGerard gerard = new LeGerard();

            Console.WriteLine("=== CHOIX DU PREMIER COMBATTANT ===");
            Console.WriteLine("1. Renaud");
            Console.WriteLine("2. Gerard");
            Console.Write("Choisissez le premier combattant (1-2): ");

            string choix1 = Console.ReadLine();
            Ivrogne combattant1, combattant2;

            if (choix1 == "1")
            {
                combattant1 = renaud;
                Console.WriteLine("Premier combattant: Renaud");
                Console.WriteLine("Deuxième combattant: Gerard");
                combattant2 = gerard;
            }
            else if (choix1 == "2")
            {
                combattant1 = gerard;
                Console.WriteLine("Premier combattant: Gerard");
                Console.WriteLine("Deuxième combattant: Renaud");
                combattant2 = renaud;
            }
            else
            {
                Console.WriteLine("Choix invalide ! Par défaut: Renaud vs Gerard");
                combattant1 = renaud;
                combattant2 = gerard;
            }

            Ivrogne.Duel(combattant1, combattant2);

            Console.ReadKey();
        }
    }
}
