public class JohnnyDeFeu : LeJohnny
{
    // -- CONSTRUCTEUR --
    public JohnnyDeFeu() : base("Johnny de feu", 100, 4)
    {
        Console.WriteLine("Johnny le Flamboyant apparaît !");


        // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "Est-ce que vous êtes là ce soir ?! Moi non plus !",
            "Quelque chose de Tennessee... dans ta mâchoire.",
            "WOooptic 2000 !",
            "Je te promets... une droite et un crochet.",
            "Le pénitencier ? Je t’y envoie en première classe.",
            "J’ai bu 3 Ricard, 2 Jack… il me reste ta gueule.",
            "J’ai la rage… ou la cirrhose, j’sais plus. Mais j’vais te frapper.",
        };

        TauntsDefense = new List<string>
        {
            "Tu te rend compte. Si on avait pas perdu une heure et quart, on serait la depuis une heure et quart..",
            "J'ai mal à la France, j'ai mal à ma guitare… mais pas à tes baffes !",
            "C'est quand même mieu de venir chanter à Tahiti qu'a Maubeuge..",
            "Quoi ma gueule ? Qu'est ce qu'elle à ma gueule..",
            "Même mon foie a plus de répondant que toi.",
            "Ça pique un peu… comme un p’tit shot de tequila mal placé.",
        };
    }
    

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(20, 40);
        cible.SubirDegats(degats);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{Nom} lance une bouteille d'alcool et ALLUME LE FEU pour {degats} dégâts !");
        Console.ResetColor();
    }
}
