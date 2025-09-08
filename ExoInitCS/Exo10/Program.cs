//Exercice 10
Console.WriteLine("Choisissez une option :");
Console.WriteLine("1. Dire Bonjour");
Console.WriteLine("2. Dire Au revoir");
Console.WriteLine("3. Quitter");
int choix = Convert.ToInt32(Console.ReadLine());
switch (choix)
{
    case 1:
        Console.WriteLine("Bonjour !");
        break;
    case 2:
        Console.WriteLine("Au revoir !");
        break;
    case 3:
        Console.WriteLine("Entrain de quitter...");
        break;
    default:
        Console.WriteLine("Choix invalide.");
        break;
}