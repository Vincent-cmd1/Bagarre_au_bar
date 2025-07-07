public class LeRenaudTeigne : LeRenaud
{
    // -- CONSTRUCTEUR -- 
    public LeRenaudTeigne()
    {
        Nom = "Renaud la Teigne";
        PointsDeVie = PointsDeVieMax = 75;
        FrequenceAptitude = 2;
        Console.WriteLine("Renaud la Teigne débarque, clope au bec, veste en cuir et Kro à la main.");


        // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "Tu vas voir comment on cause dans mon HLM !",
            "Casse-toi, pauv’ con !",
            "A pas vouloir vieillir on meurt avant les autres !",
            "Je t’ai vu hésiter à prendre un Perrier. Fallait pas.",
            "J’ai pas fait 68 pour me laisser taper dessus par un clown !",
            "J’t’ai pas reconnu avec ta tête de bourgeois !",
            "J’te parle pas avec les mots, j’te parle avec les poings !",
            "Un verre, une clope, une droite. L’ordre des choses.",
            "C’est pas moi qui suis violent, c’est la société !",
            "J’vais te rééduquer à coups d’accordéon dans la tronche !"
        };

        TauntsDefense = new List<string>
        {
            "T’appelles ça une baffe ? J’ai connu pire dans mon HLM !",
            "Même le fisc fait plus mal que toi.",
            "Ma daronne m’en collait des pires pour moins que ça.",
            "Tu frappes mou, camarade…",
            "T'as la main molle comme ton bulletin de vote !",
            "On dirait une claque de CRS fatigué, ça !",
            "J’en ai pris des pires en montant dans le métro.",
            "C’est pas avec ça que tu vas renverser le système !",
            "Tu veux faire mal ? Faut viser la dignité, c****** !",
            "Essaie avec une idée, ça me fera plus d'effet.",
        };
    }

    // -- Aptitude active : Jet de Kro --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(15, 25);
        cible.SubirDegats(degats);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\"Tiens, prends ça pauv’ con !\" — Renaud la Teigne balance sa Kro dans la tronche de {cible.Nom} ({degats} dégâts).");
        Console.ResetColor();
    }

    // -- Aptitude passive : Réduction des dégâts --
    public override void SubirDegats(int degats)
    {
        int reduction = 5; // Armure passive de cuir
        int degatsReduits = Math.Max(degats - reduction, 0);
        base.SubirDegats(degatsReduits);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{Nom} encaisse avec sa veste en cuir : dégâts réduits de {reduction} !");
        Console.ResetColor();
    }
}