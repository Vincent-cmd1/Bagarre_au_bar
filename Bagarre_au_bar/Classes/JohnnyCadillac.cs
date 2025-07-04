public class JohnnyCadillac : LeJohnny
{
    // -- CONSTRUCTEUR --
    public JohnnyCadillac() : base("Johnny Cadillac", 100, 5)
    {
        Console.WriteLine("Johnny Cadillac, Maitre de la bagarre apparait !");
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(25, 50);
        cible.SubirDegats(degats);
        Console.WriteLine($"{Nom} fait un URACAN et inflige {degats} dégâts !");
    }
}
