using System;

public class LeRenaud : Ivrogne
{
    // -- CONSTRUCTEUR --
    public LeRenaud() : base("Le Renaud", 100, 100, 4) // FrequenceAptitude = tous les 4 tours
    {
        Console.WriteLine("Le Renaud (base test)");
    }

    // -- MÉTHODE D'ATTAQUE CLASSIQUE --
    public override int Attaquer()
    {
        int attaquebasique = random.Next(2, 12);
        Console.WriteLine($"{Nom} a infligé {attaquebasique} dégâts");
        return attaquebasique;
    }

    // -- MÉTHODE D'APTITUDE SPÉCIALE --

    public override void AptitudeSpecial(Ivrogne cible)
    {
        int attaqueSpeciale = random.Next(15, 25);
        cible.SubirDegats(attaqueSpeciale);
        Console.WriteLine($"{Nom} utilise SUPER PUNCH et inflige {attaqueSpeciale} dégâts !");
    }
}
