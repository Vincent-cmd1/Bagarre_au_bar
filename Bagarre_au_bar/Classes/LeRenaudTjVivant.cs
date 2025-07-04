public class LeRenaudTjVivant : LeRenaud
{
    public LeRenaudTjVivant() : base()
    {
        Nom = "Renaud Toujours Vivant";
        PointsDeVie = 70;
        PointsDeVieMax = 70;
        FrequenceAttaqueSpeciale = 4; // Tous les quatre tours
        Console.WriteLine("Renaud apparait, et il est toujours vivant !");
    }

    public override int AptitudeSpecial()
    {
        int aptitudeSpeciale = random.Next(10, 30);
        Console.WriteLine($"Toujours debout, toujours la banane..{Nom} est toujours vivant. Il recupère {aptitudeSpeciale} points de vie !");
        return aptitudeSpeciale;
    }
}