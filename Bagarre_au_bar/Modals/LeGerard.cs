using System;

public abstract class LeGerard : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeGerard() : base("Le Gerard", 100, 100, 3)
    {
        // Pas de message 
    }

    // -- METHODE D'ATTAQUE BASIQUE --
    public override int Attaquer()
    {
        TenterTaunt(TauntsAttaque);
        int attaquebasique = random.Next(2, 12);
        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");
        return attaquebasique;
    }
}
