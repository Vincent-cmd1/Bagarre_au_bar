using System;

public abstract class LeJohnny : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeJohnny(string nom, int pv, int frequence) : base(nom, pv, pv, frequence)
    {
        // Pas de message 
    }

    // -- METHODE D'ATTAQUE BASIQUE --
    public override int Attaquer()
    {
        TenterTaunt(TauntsAttaque);
        int degats = random.Next(2, 18);
        Console.WriteLine($"{Nom} a infligé {degats} dégâts");
        return degats;
    }
}