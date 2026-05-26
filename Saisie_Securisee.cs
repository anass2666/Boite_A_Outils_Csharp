// Modèle pour demander un entier et gérer les erreurs
int DemanderEntier()
{
    int nombre = 0;
    bool saisieValide = false;
    
    do 
    {
        Console.WriteLine("Veuillez saisir un nombre entier :");
        try 
        {
            nombre = Convert.ToInt32(Console.ReadLine());
            saisieValide = true; // Si ça plante au-dessus, cette ligne n'est pas lue
        }
        catch (Exception e) 
        {
            Console.WriteLine("Erreur de saisie : " + e.Message);
        }
    } while (saisieValide == false);
    
    return nombre;
}
