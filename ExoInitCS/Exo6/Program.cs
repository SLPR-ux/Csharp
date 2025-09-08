//Exercice 6
Console.WriteLine("Entrez le premier nombre :");
int nombre1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Entrez le deuxième nombre :");
int nombre2 = Convert.ToInt32(Console.ReadLine());
if (nombre1 > nombre2)
{
    Console.WriteLine("Le premier nombre est le plus grand.");
}
else if (nombre1 < nombre2)
{
    Console.WriteLine("Le deuxième nombre est le plus grand.");
}
else
{
    Console.WriteLine("Les deux nombres sont identiques.");
}