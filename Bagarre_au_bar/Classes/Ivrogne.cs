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

        Console.WriteLine($"{Nom} a maintenant {PointsDeVie}/{PointsDeVieMax} PV");
    }

    public bool EstEnVie()
    {
        return PointsDeVie > 0;
    }

    // Afficher les status
    public virtual void AfficherStatut()
    {
        Console.WriteLine($"{Nom}: {PointsDeVie}/{PointsDeVieMax} PV");
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
        Console.WriteLine($"{Nom} a gagné !");
    }

    public virtual void AnnoncerDefaite()
    {
        Console.WriteLine($"{Nom} est K.O. !");
    }
}
