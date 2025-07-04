using System;

public abstract class LeRenaud : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeRenaud() : base("Le Renaud", 100, 100, 4) // FrequenceAptitude = tous les 4 tours
    {
        // Pas de message 
    }

    // -- MÉTHODE D'ATTAQUE CLASSIQUE --
    public override int Attaquer()
    {
        int attaquebasique = random.Next(2, 12);
        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");
        return attaquebasique;
    }
}
