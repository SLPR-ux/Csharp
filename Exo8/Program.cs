//Exercice 8
Console.WriteLine("Entrez le premier nombre :");
int nombre1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre :");
int nombre2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez l'opérateur (+, -, *, /) :");
char operateur = Console.ReadLine()[0];
switch (operateur)
{
    case '+':
        Console.WriteLine("Le résultat est : " + (nombre1 + nombre2));
        break;
    case '-':
        Console.WriteLine("Le résultat est : " + (nombre1 - nombre2));
        break;
    case '*':
        Console.WriteLine("Le résultat est : " + (nombre1 * nombre2));
        break;
    case '/':
        if (nombre2 != 0)
        {
            Console.WriteLine("Le résultat est : " + ((double)nombre1 / nombre2));
        }
        else
        {
            Console.WriteLine("Division par zéro impossible.");
        }
        break;
    default:
        Console.WriteLine("Opérateur invalide.");
        break;
}
