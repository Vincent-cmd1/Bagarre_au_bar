using System;

public abstract class Ivrogne
    {
        // -- PROPRIETES --

        public string Nom { get; }  // Le nom de l'ivrogne.
        public int PointsDeVie { get; set; } // Les points de vie(PV) de l'ivrogne.
        public int NbDesAttaque { get; set; } // Le nombre de dés d’attaque.
        public int PointsDeVieMax { get; set; } // Points de vie max
        public Random random = new Random();

        // -- CONSTRUCTEUR --

        public Ivrogne(string nom, int pointsDeVie, int pointsDeVieMax)
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            PointsDeVieMax = pointsDeVieMax;
        }

        public abstract int Attaque();

        // -- METHODE --

        public virtual void MajPdv(int Attaque)
        {
            PointsDeVie -= Attaque;

            if (PointsDeVie < 0)
                PointsDeVie = 0;

            Console.WriteLine($"{Nom} a maintenant {PointsDeVie}/{PointsDeVieMax}");
        }

        public bool EstEnVie()
        {
            return PointsDeVie > 0;
        }
    }
