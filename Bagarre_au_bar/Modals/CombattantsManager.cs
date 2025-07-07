using System;
using System.Collections.Generic;

public static class CombattantsManager
{
    public static List<Ivrogne> ObtenirTousLesCombattants()
    {
        return new List<Ivrogne>
        {
            new LeRenaudTjVivant(),
            new LeRenaudTeigne(),
            new GerardMince(),
            new GrosGerard(),
            new JohnnyDeFeu(),
            new JohnnyCadillac()
        };
    }
}
