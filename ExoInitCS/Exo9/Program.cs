//Exercice 9

Console.WriteLine("Entrez une note entre 0 et 20 :");
int note = Convert.ToInt32(Console.ReadLine());
switch (note)
{
    case int n when (n >= 0 && n <= 9):
        Console.WriteLine("Insuffisant");
        break;
    case int n when (n >= 10 && n <= 13):
        Console.WriteLine("Moyen");
        break;
    case int n when (n >= 14 && n <= 16):
        Console.WriteLine("Bien");
        break;
    case int n when (n >= 17 && n <= 20):
        Console.WriteLine("Excellent");
        break;
    default:
        Console.WriteLine("Note invalide.");
        break;
}