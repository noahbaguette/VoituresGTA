namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        String[] garage={ "Banshee", "Zentorno", "Sultan" , "Sanchez" , "Buzzard" };
        for (int i=0; i<garage.Length; i++)
        {
            Console.WriteLine((i + 1).ToString() + "." + garage[i]);
        }
        Console.WriteLine("Dis moi ton choix entre 1 et 5 ");
        int choose=Convert.ToInt32(Console.ReadLine());
        string car=System.Array.IndexOf(garage.[choose]);
        Console.WriteLine("Tu as choisi  " +car);
        Console.WriteLine("Donne lui un nouveau nom");
        String rename = Console.ReadLine();
    }
}