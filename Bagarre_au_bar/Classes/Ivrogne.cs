using System;

public abstract class Ivrogne
{
    // -- PROPRIETES --

    private string Nom { get; }  // Le nom de l'ivrogne.
    private int PointsDeVie { get; set; } // Les points de vie(PV) de l'ivrogne.
    private int NbDesAttaque { get; set; } // Le nombre de dés d’attaque.

    // -- CONSTRUCTEUR --

    public Ivrogne(string nom, int pointsDeVie) 
    {
        Nom = nom;
        PointsDeVie = pointsDeVie;
    }

    // -- METHODE --
    
}
