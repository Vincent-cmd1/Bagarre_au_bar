using System;

public abstract class Ivrogne
{
    public string Nom { get; set; }
    public int PointsDeVie { get; set; }
    public int NbDesAttaque { get; set; }
    public int PointsDeVieMax { get; set; }
    public int FrequenceAttaqueSpeciale { get; set; } // Pour simuler les tours
    public Random random = new Random();

    public Ivrogne(string nom, int pointsDeVie, int pointsDeVieMax, int frequenceAttaqueSpeciale = 3)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
        PointsDeVieMax = pointsDeVieMax;
        FrequenceAttaqueSpeciale = frequenceAttaqueSpeciale;
    }

    public abstract int Attaque();
    public abstract int AttaqueSpeciale();
    public abstract int AptitudeSpeciale();

    public virtual bool PeutFaireAttaqueSpeciale(int tour) // 
    {
        return tour % FrequenceAttaqueSpeciale == 0;
    }

    public virtual void MajPdv(int degats)
    {
        PointsDeVie -= degats;

        if (PointsDeVie < 0)
            PointsDeVie = 0;

        Console.WriteLine($"{this.Nom} a maintenant {PointsDeVie}/{PointsDeVieMax} PV");
    }

    public bool EstEnVie()
    {
        return PointsDeVie > 0;
    }

    public virtual void AfficherStatut()
    {
        Console.WriteLine($"{this.Nom}: {PointsDeVie}/{PointsDeVieMax} PV");
    }

    public virtual void AttaquerAdversaire(Ivrogne adversaire)
    {
        if (this.EstEnVie() && adversaire.EstEnVie())
        {
            int degats = this.Attaque();
            adversaire.MajPdv(degats);
        }
    }

    public virtual void AttaqueSpecialeAdversaire(Ivrogne adversaire)
    {
        if (this.EstEnVie() && adversaire.EstEnVie())
        {
            int degats = this.AttaqueSpeciale();
            adversaire.MajPdv(degats);
        }
    }

    public virtual void AnnoncerVictoire()
    {
        Console.WriteLine($"{this.Nom} a gagné !");
    }

    public virtual void AnnoncerDefaite()
    {
        Console.WriteLine($"{this.Nom} est K.O. !");
    }

    public static void Duel(Ivrogne combattant1, Ivrogne combattant2)
    {
        Console.WriteLine($"=== DUEL: {combattant1.Nom} VS {combattant2.Nom} ===");
        Console.WriteLine($"{combattant1.Nom} utilise l'attaque spéciale tous les {combattant1.FrequenceAttaqueSpeciale} tours");
        Console.WriteLine($"{combattant2.Nom} utilise l'attaque spéciale tous les {combattant2.FrequenceAttaqueSpeciale} tours");

        int tour = 1;

        while (combattant1.EstEnVie() && combattant2.EstEnVie() && tour <= 20)
        {
            Console.WriteLine($"\n----- Tour {tour} -----");
            combattant1.AfficherStatut();
            combattant2.AfficherStatut();

            Console.WriteLine();
            if (combattant1.PeutFaireAttaqueSpeciale(tour))
            {
                Console.WriteLine($"{combattant1.Nom} - ATTAQUE SPÉCIALE");
                combattant1.AttaqueSpecialeAdversaire(combattant2);
            }
            else
            {
                combattant1.AttaquerAdversaire(combattant2);
            }

            Console.WriteLine();

            if (combattant2.EstEnVie())
            {
                if (combattant2.PeutFaireAttaqueSpeciale(tour))
                {
                    Console.WriteLine($"{combattant2.Nom} - ATTAQUE SPÉCIALE");
                    combattant2.AttaqueSpecialeAdversaire(combattant1);
                }
                else
                {
                    combattant2.AttaquerAdversaire(combattant1);
                }
            }

            Console.ReadKey();
            tour++;
        }

        Console.WriteLine("\n=== RÉSULTAT ===");

        if (!combattant1.EstEnVie())
        {
            combattant1.AnnoncerDefaite();
            combattant2.AnnoncerVictoire();
        }
        else if (!combattant2.EstEnVie())
        {
            combattant2.AnnoncerDefaite();
            combattant1.AnnoncerVictoire();
        }
        else
        {
            Console.WriteLine("Match nul après 20 tours !");
        }
    }
}
