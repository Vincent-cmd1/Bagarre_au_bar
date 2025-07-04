public class GrosGerard : LeGerard
{
    public GrosGerard() : base()
    {
        Nom = "Gros Gerard";
        PointsDeVie = 120;
        PointsDeVieMax = 120;
        FrequenceAttaqueSpeciale = 3; // Tous les 3 tours
        Console.WriteLine("Super Gerard apparaît !");
    }

    public override int AttaqueSpeciale()
    {
        int attaqueSpeciale = random.Next(15, 25);
        Console.WriteLine($"{Nom} utilise MEGA-BAFFE et inflige {attaqueSpeciale} dégâts !");
        return attaqueSpeciale;
    }
}
