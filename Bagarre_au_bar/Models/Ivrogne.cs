using System;

public abstract class Ivrogne
{
    // -- PROPRIETE -- 
    public string Nom { get; protected set; }

    public int PointsDeVie { get; protected set; }

    /*public int NbDesAttaque { get; protected set; }*/
    public int PointsDeVieMax { get; protected set; }
    public int FrequenceAptitude { get; protected set; }

    protected static readonly Random random = new();

    // -- CONSTRUCTEUR --
    protected Ivrogne(string nom, int pointsDeVie, int pointsDeVieMax, int frequenceAptitude)
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
        PointsDeVieMax = pointsDeVieMax;
        FrequenceAptitude = frequenceAptitude;
    }

    /*public abstract int Attaque();
    public abstract int AttaqueSpeciale();
    public abstract void AptitudeSpecial(Ivrogne cible);*/

    // -- LES METHODES --

    // - METHODE D'ATTAQUE NORMALE - 

    public virtual int Attaquer()
    {
        int degats = random.Next(5, 15);
        Console.WriteLine($"{Nom} met une baffe et inflige {degats} dégâts !");
        return degats;
    }

    // - METHODE D'APTITUDE SPECIALE - 

    public abstract void AptitudeSpecial(Ivrogne cible);

    // - METHODE DE COMBAT : UTILITAIRES -

    public void SubirDegats(int degats)
    {
        PointsDeVie -= degats;
        if (PointsDeVie < 0) PointsDeVie = 0;
    }

    public void Soigner(int soin)
    {
        PointsDeVie += soin;
        if (PointsDeVie > PointsDeVieMax)
            PointsDeVie = PointsDeVieMax;
    }

    public bool EstEnVie()
    {
        return PointsDeVie > 0;
    }

    public virtual void AfficherStatut()
    {
        Console.WriteLine($"{this.Nom}: {PointsDeVie}/{PointsDeVieMax} PV");
    }

    // DUEL : METHODE POUR GERER UN COMBAT

    public static void Duel(Ivrogne a, Ivrogne b)
    {
        int tour = 1;
        while (a.EstEnVie() && b.EstEnVie())
        {
            Console.WriteLine($"\n--- Tour {tour} ---");

            // Tour du combattant A
            if (tour % a.FrequenceAptitude == 0)
                a.AptitudeSpecial(b);
            else
                b.SubirDegats(a.Attaquer());

            if (!b.EstEnVie()) break;

            // Tour du combattant B
            if (tour % b.FrequenceAptitude == 0)
                b.AptitudeSpecial(a);
            else
                a.SubirDegats(b.Attaquer());

            // Affichage
            a.AfficherStatut();
            b.AfficherStatut();

            tour++;
            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadKey();
        }

        // Fin du combat
        Console.WriteLine("\n=== FIN DU COMBAT ===");
        Console.WriteLine(a.EstEnVie()
            ? $"{a.Nom} remporte la bagarre !"
            : $"{b.Nom} remporte la bagarre !");
    }
}














/*
/*
public virtual bool PeutFaireAttaqueSpeciale(int tour)
{
    return tour % FrequenceAttaqueSpeciale == 0;
}

public virtual void MajPdv(int degats)
{
    PointsDeVie -= degats;

    if (PointsDeVie < 0)
        PointsDeVie = 0;

    Console.WriteLine($"{this.Nom} a maintenant {PointsDeVie}/{PointsDeVieMax} PV");
}#1#





    /*public virtual void AttaquerAdversaire(Ivrogne adversaire)
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
    }#1#

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
*/
