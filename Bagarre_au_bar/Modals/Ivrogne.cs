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

    public virtual void SubirDegats(int degats)
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