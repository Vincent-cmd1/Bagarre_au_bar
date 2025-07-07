public class GerardMince : LeGerard
{
    public GerardMince() : base()
    {
        Nom = "Gerard Mince";
        PointsDeVie = PointsDeVieMax = 90;
        FrequenceAptitude = 2; // Tous les 2 tours
        Console.WriteLine("Gérard Mince entre discrètement...");
    
            // -- Les Taunts --
        TauntsAttaque = new List<string>
        {
            "Tu veux goûter à mes Valseuses ? Avance, champion.",
            "Je suis l’insolence faite homme. Et poing.",
            "Tu parles trop. Moi j’joue brut.",
            "Tu veux pas une p’tite trempette dans mon bain de claques ?",
            "Je t’en colle une et tu récites du Pagnol en pleurant.",
            "Tu pues la trouille, ça me donne la dalle !",
            "Ma main, elle joue tous les rôles : tendresse, baston, claque.",
            "T’as vu mon nez ? C’est une œuvre d’art faite à coups d’amour et de bagarre.",
            "Tu m’reconnaîtras quand j’te r’collerai la mâchoire.",
            "Je suis l’instinct, le désir, le chaos en blouson de cuir !",
            "Allez viens, on va s’en mettre plein la gueule, et après on boira un canon.",
        };

        TauntsDefense = new List<string>
        {
            "Ça ? C’est une claque ou un courant d’air ?",
            "J’ai connu des nuits blanches plus violentes que toi.",
            "Même ma gueule de bois est plus charismatique que toi.",
            "T’as touché mon corps, pas mon âme. L’erreur des débutants.",
            "Mon sourire te répond, et mon foie aussi.",
            "T’as mis ta force dans ton haleine ou quoi ?",
            "Frappe encore ! J’suis en train d’me rappeler une réplique.",
            "HAHAHAHA ! (rire qui pue la clope, le rouge et le mépris)",
        };
    }

    public override void AptitudeSpecial(Ivrogne cible)
    {
        int degats = random.Next(12, 22);
        cible.SubirDegats(degats);

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{Nom} utilise ATTAQUE ÉCLAIR et inflige {degats} dégâts !");
        Console.ResetColor();
    }
}
