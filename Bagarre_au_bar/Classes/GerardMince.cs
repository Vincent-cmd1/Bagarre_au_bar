public class GerardMince : LeGerard
{
    public GerardMince() : base()
    {
        Nom = "Gerard Mince";
        PointsDeVie = 90;
        PointsDeVieMax = 90;
        FrequenceAttaqueSpeciale = 2; // Tous les deux tours
        Console.WriteLine("Gerard Mince apparaît !");
    }

    public override int AttaqueSpeciale()
    {
        int attaqueSpeciale = random.Next(12, 22);
        Console.WriteLine($"{Nom} utilise ATTAQUE ÉCLAIR et inflige {attaqueSpeciale} dégâts !");
        return attaqueSpeciale;
    }
}
