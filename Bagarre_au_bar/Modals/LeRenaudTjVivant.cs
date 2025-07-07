public class LeRenaudTjVivant : LeRenaud
{
    // -- CONSTRUCTEUR --
    public LeRenaudTjVivant()
    {
        Nom = "Renaud Toujours Vivant";
        PointsDeVie = PointsDeVieMax = 90;
        FrequenceAptitude = 3;
        Console.WriteLine("Renaud apparaît, toujours vivant !");

        // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "Toujours vivant, toujours là pour t’en coller une !",
            "On m’enterre pas si vite, pépère !",
            "J’ai fait 40 ans de scène, j’peux faire 10 secondes de baston.",
            "J’viens de loin, et j’vais pas m’arrêter devant ta gueule.",
            "Docteur Renaud frappe. Mister Renard roupille.",
            "J’ai plus d’voix mais j’ai encore du répondant !",
            "J’vais t’écrire un couplet dans la tronche, il rime avec mandale.",
            "T’as voulu Manhattan ? T’auras Kaboul !",
            "J’suis vacciné contre les cons, mais pas contre les coups de poing.",
            "Le poing gauche, c’est le *Mistral Gagnant*. Le droit, c’est le *Boucan d’Enfer*."
        };

        TauntsDefense = new List<string>
        {
            "T’as voulu la bagarre ? T’as eu le vieux Renaud.",
            "J’m’effondre pas.. je fais une pause.",
            "J’suis tombé plus bas… et j’me suis toujours relevé.",
            "Mon foie a pris plus de baffes que toi.",
            "Celle-là, j’la sens jusqu’au foie !",
            "J’ai survécu au showbiz, tu crois que c’est toi qui va m’foutre par terre ?",
            "Tu veux me faire taire ? J’suis sourd de toute façon.",
            "Je tombe pas, j’me repose.",
            "Tu frappes comme un journaliste."
        };
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int soin = random.Next(20, 30);
        Soigner(soin);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Toujours debout, toujours la banane… {Nom} récupère {soin} PV !");
        Console.ResetColor();
    }
}
