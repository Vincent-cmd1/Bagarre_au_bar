public class GrosGerard : LeGerard
{
    // -- CONSTRUCTEUR --
    public GrosGerard()
    {
        Nom = "Gros Gérard";
        PointsDeVie = PointsDeVieMax = 120;
        FrequenceAptitude = 3;
        Console.WriteLine("Gros Gérard arrive au bar !");
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(20, 30);
        cible.SubirDegats(degats);
        Console.WriteLine($"{Nom} utilise MEGA-BAFFE ! Il inflige {degats} dégâts !");
    }
}