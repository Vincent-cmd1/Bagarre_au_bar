namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            LeRenaud renaud1 = new LeRenaud();
            LeGerard gerard1 = new LeGerard();

            Console.WriteLine("=== COMBAT ===");

            int tour = 1;

            while (renaud1.EstEnVie() && gerard1.EstEnVie() && tour <= 20)
            {
                Console.WriteLine($" ----- Tour {tour} ----");
                Console.WriteLine($"{renaud1.Nom}: {renaud1.PointsDeVie}/{renaud1.PointsDeVieMax} Points de vie et {gerard1.Nom}: {gerard1.PointsDeVie}/{gerard1.PointsDeVieMax} Points de vie");
                int degatsJ1 = renaud1.Attaque();
                int degatsJ2 = gerard1.Attaque();

                renaud1.MajPdv(degatsJ1);
                gerard1.MajPdv(degatsJ2);

                tour++;

                if (!renaud1.EstEnVie()) { 
                    Console.WriteLine($"\n{renaud1.Nom} est K.O.");
                    Console.WriteLine($"\n{gerard1.Nom} a Gagné !.");
                }
                   

                if (!gerard1.EstEnVie()) 
                {
                    Console.WriteLine($"\n{gerard1.Nom} est K.O.");
                    Console.WriteLine($"\n{renaud1.Nom} a Gagné !.");
                }
                    

            }

            Console.ReadKey();
        }
    }
}
