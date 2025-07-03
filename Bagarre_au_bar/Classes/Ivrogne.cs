using System;

public abstract class Ivrogne
{
    public string Nom { get; }
    public int PointsDeVie { get; set; }
    public int NbDesAttaque { get; set; }
    public int PointsDeVieMax { get; set; }
    public Random random = new Random();

    public Ivrogne(string nom, int pointsDeVie, int pointsDeVieMax)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
        PointsDeVieMax = pointsDeVieMax;
    }

    public abstract int Attaque();

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

        int tour = 1;

        while (combattant1.EstEnVie() && combattant2.EstEnVie() && tour <= 20)
        {
            Console.WriteLine($"\n----- Tour {tour} -----");
            combattant1.AfficherStatut();
            combattant2.AfficherStatut();

            Console.WriteLine();

            combattant1.AttaquerAdversaire(combattant2);

            Console.WriteLine();

            if (combattant2.EstEnVie())
                combattant2.AttaquerAdversaire(combattant1);

            //System.Threading.Thread.Sleep(2000); // 2 secs d'attente

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
