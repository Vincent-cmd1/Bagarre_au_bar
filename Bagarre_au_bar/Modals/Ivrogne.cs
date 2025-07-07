using System;

public abstract class Ivrogne
{
    // -- PROPRIETE -- 
    public string Nom { get; protected set; }

    public int PointsDeVie { get; protected set; }
    public int PointsDeVieMax { get; protected set; }
    public int FrequenceAptitude { get; protected set; }

    protected static readonly Random random = new();

    // Liste des taunts
    public List<string> TauntsAttaque = new(); 
    public List<string> TauntsDefense = new();
    public double ProbaTaunt = 0.4; // 40% de chance de lancer un taunt

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
        TenterTaunt(TauntsAttaque);
        int degats = random.Next(5, 15);
        Console.WriteLine($"{Nom} met une baffe et inflige {degats} dégâts !");
        return degats;
    }

    // - METHODE D'APTITUDE SPECIALE - 

    public abstract void AptitudeSpecial(Ivrogne cible);

    // - METHODE DES TAUNTS

    public void TenterTaunt(List<string> liste)
    {
        if (liste.Count == 0 || random.NextDouble() >= ProbaTaunt)
            return;

        string phrase = liste[random.Next(liste.Count)];
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{Nom} : \"{phrase}\"");
        Console.ResetColor();
    }

    // - METHODE DE COMBAT : UTILITAIRES -

    public virtual void SubirDegats(int degats)
    {
        PointsDeVie -= degats;
        if (PointsDeVie < 0) PointsDeVie = 0;
        TenterTaunt(TauntsDefense);
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

    // TOURNOI : METHODE POUR REINITIALISER LES PDV

    public void Reinitialiser()
    {
        this.PointsDeVie = this.PointsDeVieMax;
    }

    // COMBAT AVEC RETOUR DU GAGNANT (pour le tournoi mais avec pauses)
    public static Ivrogne Combat(Ivrogne a, Ivrogne b)
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

        // Fin du combat - RETOURNE LE GAGNANT
        Console.WriteLine("\n=== FIN DU COMBAT ===");
        if (a.EstEnVie())
        {
            Console.WriteLine($"{a.Nom} remporte la bagarre !");
            return a;
        }
        else
        {
            Console.WriteLine($"{b.Nom} remporte la bagarre !");
            return b;
        }
    }

    // COMBAT RAPIDE POUR LE TOURNOI (petites pauses entre tours pouréviter la lenteur)
    public static Ivrogne CombatRapide(Ivrogne a, Ivrogne b)
    {
        Console.WriteLine($"\n{a.Nom} VS {b.Nom}");
        Console.WriteLine($"{a.Nom}: {a.PointsDeVie} PV | {b.Nom}: {b.PointsDeVie} PV"); // ✅ CORRIGÉ

        int tour = 1;
        while (a.EstEnVie() && b.EstEnVie())
        {
            Console.WriteLine($"\n--- TOUR {tour} ---");

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

            // Récap des PV après le tour
            Console.WriteLine($"PV restants: {a.Nom} ({a.PointsDeVie}) | {b.Nom} ({b.PointsDeVie})"); // ✅ CORRIGÉ

            tour++;
            System.Threading.Thread.Sleep(300);
        }

        // Retourner le gagnant
        if (a.EstEnVie())
        {
            Console.WriteLine($"{a.Nom} remporte le combat !");
            return a;
        }
        else
        {
            Console.WriteLine($"{b.Nom} remporte le combat !");
            return b;
        }
    }

    // DUEL : METHODE POUR GERER UN COMBAT (avec pauses)
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