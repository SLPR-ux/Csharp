//Exercice 2

Console.Write("Entrez un nombre: ");
int nombre = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(nombre + " x " + i + " = " + (nombre * i));
}