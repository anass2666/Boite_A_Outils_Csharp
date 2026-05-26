using System;

class ParametresExemple
{
    // Passage par RÉFÉRENCE (ref) : modifie la variable d'origine
    static void ModifierVariable(ref int a)
    {
        a = a + 10;
    }

    // Passage par SORTIE (out) : remplit une variable vide
    static void InitialiserValeur(out int a)
    {
        a = 0; 
    }
}
