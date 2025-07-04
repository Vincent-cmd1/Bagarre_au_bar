public class JohnnyDeFeu : LeJohnny
{
    public JohnnyDeFeu() : base()
    {
        Nom = "Johnny de feu";
        PointsDeVie = 100;
        PointsDeVieMax = 100;
        FrequenceAttaqueSpeciale = 4; // Tous les 4 tours
        Console.WriteLine("Johnny le Flamboyant apparaît !");
    }

    public override int AttaqueSpeciale()
    {
        int attaqueSpeciale = random.Next(20, 40);
        Console.WriteLine($"{Nom} lance une bouteille d'alcool et ALLUME LE FEU pour faire {attaqueSpeciale} dégâts !");
        return attaqueSpeciale;
    }
}
