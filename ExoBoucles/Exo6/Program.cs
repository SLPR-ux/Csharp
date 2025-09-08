//Exercice 6 

int[] nombres = { 3, 7, 2, 9, 4 };
int somme = 0;
foreach (int nombre in nombres)
{
    somme = nombre + somme;
}
Console.WriteLine("La somme des éléments du tableau est : " + somme);