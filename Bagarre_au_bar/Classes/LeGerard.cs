//using System;

public class LeGerard : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeGerard() : base("Le Gerard", 100, 100)
    {
        Console.WriteLine("Le Gerard (base test)");
    }

    // -- METHODE --
    public override int Attaque()
    {
        int attaquebasique = random.Next(2, 12);

        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");

        return attaquebasique;
    }
}

