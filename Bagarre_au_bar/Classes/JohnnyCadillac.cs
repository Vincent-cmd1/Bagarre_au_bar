public class JohnnyCadillac : LeJohnny
{
    public JohnnyCadillac() : base()
    {
        Nom = "Johnny Cadillac";
        PointsDeVie = 100;
        PointsDeVieMax = 100;
        FrequenceAttaqueSpeciale = 5; // Tous les 5 tours
        Console.WriteLine("Johnny Cadillac, Maitre de la bagarre apparait !");
    }

    public override int AttaqueSpeciale()
    {
        int attaqueSpeciale = random.Next(25, 50);
        Console.WriteLine($"{Nom} fait un HURACAN et inflige {attaqueSpeciale} dégâts !");
        return attaqueSpeciale;
    }
}
