using System;

public abstract class LeGerard : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeGerard() : base("Le Gerard", 100, 100, 3)
    {
        Console.WriteLine("Le Gerard (base test)");
    }

    // -- METHODE D'ATTAQUE BASIQUE --
    public override int Attaquer()
    {
        int attaquebasique = random.Next(2, 12);
        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");
        return attaquebasique;
    }
}
