using System;

public abstract class LeJohnny : Ivrogne
{
    public LeJohnny() : base("", 100, 100)
    {
    }

    public override int Attaque()
    {
        int attaquebasique = random.Next(2, 18);

        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");

        return attaquebasique;
    }
}

