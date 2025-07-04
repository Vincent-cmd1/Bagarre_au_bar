public class LeRenaudTjVivant : LeRenaud
{
    public LeRenaudTjVivant()
    {
        Nom = "Renaud Toujours Vivant";
        PointsDeVie = PointsDeVieMax = 70;
        FrequenceAptitude = 4;
        Console.WriteLine("Renaud apparaît, toujours vivant !");
    }

    public override void AptitudeSpecial(Ivrogne cible)
    {
        int soin = random.Next(10, 30);
        Soigner(soin);
        Console.WriteLine($"Toujours debout, toujours la banane… {Nom} récupère {soin} PV !");
    }
}