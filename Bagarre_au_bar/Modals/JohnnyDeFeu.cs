public class JohnnyDeFeu : LeJohnny
{
    // -- CONSTRUCTEUR --
    public JohnnyDeFeu() : base("Johnny de feu", 100, 4)
    {
        Console.WriteLine("Johnny le Flamboyant apparaît !");
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(20, 40);
        cible.SubirDegats(degats);
        Console.WriteLine($"{Nom} lance une bouteille d'alcool et ALLUME LE FEU pour {degats} dégâts !");
    }
}
