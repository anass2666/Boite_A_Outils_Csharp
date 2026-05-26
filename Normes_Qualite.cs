// --- RAPPELS DE QUALITÉ (Barème M. Clérentin) ---

// 1. NOMMAGE "CamelCase"
// -> Variables : maVariable (minuscule au début)
// -> Sous-programmes : MaFonction (majuscule au début)

// 2. DOCUMENTATION XML (Obligatoire avant chaque fonction)
/// <summary>
/// Description courte de la fonction.
/// </summary>
/// <param name="nom">Rôle du paramètre.</param>
/// <returns>Ce que la fonction renvoie.</returns>

// 3. SÉCURITÉ
// Toujours lever une exception si une valeur est impossible
if (valeur < 0)
{
    throw new ArgumentOutOfRangeException("La valeur ne peut pas être négative.");
}
