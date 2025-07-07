public class JohnnyCadillac : LeJohnny
{
    // -- CONSTRUCTEUR --
    public JohnnyCadillac() : base("Johnny Cadillac", 100, 5)
    {
        Console.WriteLine("Johnny Cadillac, Maitre de la bagarre apparait !");
        
        // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "Tu veux que je te montre l’Uraken ? T’as intérêt à tenir le choc !",
            "T'es pas prêt, là je t'envoie l'ouragan Cadillac !",
            "Regarde bien : ça, c’est du style Johnny… et ça part dans ta face !",
            "Je suis le sosie, mais là c’est du vrai Jack… dans ton menton !",
            "Pense pas que l’Uraken, c’est qu’un mot… attends que ça te tombe dessus !",
            "T’es prêt ? Non ? Tant pis. C’est trop tard !",
            "Ton crâne va résonner comme une légende belge !",
            "Johnny Cadillac frappe… et le bruit claque plus fort que ses solos !"
        };

        TauntsDefense = new List<string>
        {
            "Tu m’as touché ? C’était juste un teasing de l’Uraken !",
            "Ça, c’est rien… attends le prochain round !",
            "Je suis Johnny Cadillac : je cache ma fureur derrière un sourire… avant l’Uraken !",
            "Tu viens de réveiller le volcan, maintenant régale-toi !"
        };
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(25, 50);
        cible.SubirDegats(degats);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{Nom} fait un URAKEN et inflige {degats} dégâts !");
        Console.ResetColor();
    }
}
