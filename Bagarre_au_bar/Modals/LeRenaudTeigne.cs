public class LeRenaudTeigne : LeRenaud
{
    public LeRenaudTeigne()
    {
        Nom = "Renaud la Teigne";
        PointsDeVie = PointsDeVieMax = 75;
        FrequenceAptitude = 2;
        Console.WriteLine("Renaud la Teigne débarque, clope au bec, veste en cuir et Kro à la main.");
    }

    // -- Aptitude active : Jet de Kro --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(15, 25);
        cible.SubirDegats(degats);
        Console.WriteLine($"\"Tiens, prends ça pauv’ con !\" — Renaud la Teigne balance sa Kro dans la tronche de {cible.Nom} ({degats} dégâts).");
    }

    // -- Aptitude passive : Réduction des dégâts --
    public override void SubirDegats(int degats)
    {
        int reduction = 5; // Armure passive de cuir
        int degatsReduits = Math.Max(degats - reduction, 0);
        base.SubirDegats(degatsReduits);
        Console.WriteLine($"{Nom} encaisse avec sa veste en cuir : dégâts réduits de {reduction} !");
    }
}