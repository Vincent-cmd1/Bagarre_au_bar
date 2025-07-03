namespace Bagarre_au_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LeRenaud renaud = new LeRenaud();

            int degat = renaud.Attaque();


            //Console.WriteLine($"{renaud.Nom} - {renaud.PointsDeVie}");
            Console.WriteLine("Hello");


            LeRenaud renaud1 = new LeRenaud();
            LeRenaud renaud2 = new LeRenaud();

            Console.WriteLine("=== COMBAT ===");
            //Console.WriteLine($"{renaud1.Nom} vs {renaud2.Nom}");

            //Console.WriteLine($"Vie {renaud1.Nom}: {renaud1.PointsDeVie}/{renaud1.PointsDeVieMax}");

            //Console.WriteLine($"Vie {renaud2.Nom}: {renaud2.PointsDeVie}/{renaud2.PointsDeVieMax}");

            //int degat = renaud1.Attaque();
            //renaud2.MajPdv(degat);:

            int tour = 1;

            while (renaud1.EstEnVie() && renaud2.EstEnVie() && tour <= 20)
            {
                Console.WriteLine($" ----- Tour {tour} ----");
                Console.WriteLine($"{renaud1.Nom}: {renaud1.PointsDeVie}/{renaud1.PointsDeVieMax} Points de vie et {renaud2.Nom}: {renaud2.PointsDeVie}/{renaud2.PointsDeVieMax} Points de vie");
                int degats = renaud1.Attaque();
                int degats2 = renaud2.Attaque();

                renaud1.MajPdv(degats);
                renaud2.MajPdv(degats2);

                tour++;


                if (!renaud1.EstEnVie()) { 
                    Console.WriteLine($"{renaud1.Nom} est K.O.");
                }
                    

                if (!renaud2.EstEnVie())
                    Console.WriteLine($"{renaud2.Nom} est K.O.");

            }

            Console.ReadKey();
        }
    }
}
