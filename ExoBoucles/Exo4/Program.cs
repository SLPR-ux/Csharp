//Exercice 4
Random random = new Random();
int nombreMystere = random.Next(1, 100);
int essai = 0;

do
{
    Console.Write("Devinez le nombre (entre 1 et 1000) : ");
    essai = int.Parse(Console.ReadLine());

    if (essai < nombreMystere)
    {
        Console.WriteLine("Trop petit !");
    }
    else if (essai > nombreMystere)
    {
        Console.WriteLine("Trop grand !");
    }
} while (essai != nombreMystere);

Console.WriteLine("Bravo ! Vous avez trouvé le nombre.");