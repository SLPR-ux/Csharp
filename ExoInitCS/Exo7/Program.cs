//Exercice 7
Console.WriteLine("Entrez un nombre entre 1 et 7 :");
int jour = Convert.ToInt32(Console.ReadLine());
switch (jour)
{
    case 1:
        Console.WriteLine("Lundi");
        break;
    case 2:
        Console.WriteLine("Mardi");
        break;
    case 3:
        Console.WriteLine("Mercredi");
        break;
    case 4:
        Console.WriteLine("Jeudi");
        break;
    case 5:
        Console.WriteLine("Vendredi");
        break;
    case 6:
        Console.WriteLine("Samedi");
        break;
    case 7:
        Console.WriteLine("Dimanche");
        break;
    default:
        Console.WriteLine("Nombre invalide");
        break;
}