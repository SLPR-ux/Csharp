//Exercice 1
int Carre(int nombre)
{
    return nombre * nombre;
}

Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());
int resultat = Carre(nombre);
Console.WriteLine("Le carré de " + nombre + " est : " + resultat);