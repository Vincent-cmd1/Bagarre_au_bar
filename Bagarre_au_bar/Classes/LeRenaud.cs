using System;

public class LeRenaud : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeRenaud() : base("Le Renaud", 100, 100)
    {
        Console.WriteLine("Le Renaud (base test)");
    }

    // -- METHODE --
    public override int Attaque()
    {
        int attaquebasique = random.Next(2, 12);

        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");

        return attaquebasique;
    }
}
