// Exercice 3

int i = 0;
int nombre = -1;

while (nombre != 0)
{
    Console.Write("Entrez un nombre (0 pour arrêter) : ");
    nombre = int.Parse(Console.ReadLine());

    if (nombre != 0)
    {
        i = nombre + i;
        Console.WriteLine("La somme actuelle est : " + i);
    }
}