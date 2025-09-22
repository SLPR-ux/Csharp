public class Utilisateur
{
    public Utilisateur(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;
    }


    public void Afficher()
    {
        Console.WriteLine($"Prznom = {Prenom}, Nom =  {Nom}");
    }
}

public class Admin : Utilisateur
{
}
public class Client : Utilisateur
{
    public Client(string nom, string prenom, string adresse) : base(nom, prenom)
    {
        Adresse = adresse;
    }
    public Client()
    {
        Adresse = "";
    }
    public void Afficher()
    {
        Console.WriteLine($"Client : Prénom = {Prenom}, Nom =  {Nom}, Adresse = {Adresse}");
    }
}

public class Employe : Utilisateur
{
    public Employe(string nom, string prenom, string poste) : base(nom, prenom)
    {
        Poste = poste;
    }
    public Employe()
    {
        Poste = "";
    }
    public void Afficher()
    {
        Console.WriteLine($"Employé : Prénom = {Prenom}, Nom =  {Nom}, Poste = {Poste}");
    }
}