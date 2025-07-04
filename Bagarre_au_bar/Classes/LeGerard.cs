using System;

public abstract class LeGerard : Ivrogne
{
    public LeGerard() : base("Le Gerard", 100, 100)
    {
        Console.WriteLine("Le Gerard (base test)");
    }

    public override int Attaque()
    {
        int attaquebasique = random.Next(2, 12);

        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");

        return attaquebasique;
    }


}

