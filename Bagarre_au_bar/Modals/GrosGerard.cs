public class GrosGerard : LeGerard
{
    // -- CONSTRUCTEUR --
    public GrosGerard()
    {
        Nom = "Gros Gérard";
        PointsDeVie = PointsDeVieMax = 120;
        FrequenceAptitude = 3;
        Console.WriteLine("Gros Gérard arrive au bar !");

        // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "T’as vu ta tête ? On dirait un vin bouchonné.",
            "Mon haleine te rendra KO avant mon crochet.",
            "Il n'y a pas de poésie dans la haine et la violence.",
            "Le charisme, ça ne se travaille pas. Le charisme, c'est inné.",
            "Tu m’rappelles le Cyrano, sauf qu’toi t’as que la truffe.",
            "J’suis pas obèse, j’suis épais… comme ma filmographie !",
            "T’as autant de charisme qu’un yaourt nature.",
            "J’t’en mets une, façon *Jean Valjean*.",
            "Je joue la scène du grand fauve qui cogne. Action !",
            "Je suis le Bacchus de la torgnole.",
            "J’ai le vin mauvais et le coup qui porte.",
            "J’ai pissé dans plus de pays que t’as lu de livres.",
            "La cérémonie des César, ça m'a toujours fait chier !",
            "Qui est-ce qui va passer à la casserole ?",
            "T'as envie qu'on te tue ? bouh*bouh*",
        };

        TauntsDefense = new List<string>
        {
            "C'est très compliqué d'être ivre. Ça demande une certaine sagesse.",
            "Tu tapes ? Moi je rote du Pomerol.",
            "Même mon foie m’a fait plus mal que toi.",
            "Ca pue la merde un peu ?",
            "Fais gaffe, j’ai la densité d’un menhir, moi.",
            "J’ai résisté à des gueules de bois soviétiques, tu crois m’avoir ?",
            "Mon ventre a plus de vécu que ton cerveau.",
            "J’encaissais plus fort à jeun, mais je suis plus jamais à jeun.",
            "C’est pas une claque, c’est une brise d'été sur un foie en détresse.",
            "Tu frappes ? Moi j’improvise, je respire, je vis !",
            "Tu veux battre Le Gérard ? Apprends déjà à finir ton verre.",
            "Merde ! Arrête Gérard. Je fais rien moi.. *confusion*",
            "Je suis pas KO, je fais une pause digestive.",
            "Je prend des pois chiches uniquement pour avoir des gaz *confusion*",
            "J'aime bien les cidres de paysan. Les cidres qui te donne la ch*asse tout de suite..."
        };
    }

    // -- METHODE D'APTITUDE SPÉCIALE --
    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(20, 30);
        cible.SubirDegats(degats);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{Nom} utilise MEGA-BAFFE ! Il inflige {degats} dégâts !");
        Console.ResetColor();
    }
}