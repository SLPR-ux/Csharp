// Exercice 3
int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.Write("Entrez le premier entier : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Entrez le deuxième entier : ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Le plus grand entier est : " + Max(a, b));