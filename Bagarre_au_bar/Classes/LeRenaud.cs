using System;

/// < summary >
/// Summary description for LeRenaud
/// </summary>

public class LeRenaud : Ivrogne
{
    public LeRenaud() : base("Le Renaud", 100, 100)
    {
        Console.WriteLine("Le Renaud (base test)");
    }

    public override int Attaque()
    {
        int attaquebasique = random.Next(2, 12);


        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");

        return attaquebasique;
    }
}
