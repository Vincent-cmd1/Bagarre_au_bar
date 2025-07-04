public class GerardMince : LeGerard
{
    public GerardMince() : base()
    {
        Nom = "Gerard Mince";
        PointsDeVie = PointsDeVieMax = 90;
        FrequenceAptitude = 2; // Tous les 2 tours
        Console.WriteLine("Gérard Mince entre discrètement...");
    }

    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(12, 22);
        cible.SubirDegats(degats);
        Console.WriteLine($"{Nom} utilise ATTAQUE ÉCLAIR et inflige {degats} dégâts !");
    }
}
