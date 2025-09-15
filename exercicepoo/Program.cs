class Program
{
    public static void Main(string[] args)
    {
        Compte compte = new Compte();
        compte.Solde = 1500.75m;

        Titulaire titulaire = new Titulaire();
        titulaire.Id = 1;
        titulaire.Nom = "Dupont";
        titulaire.Prenom = "Jean";
        titulaire.Adresse = "10 rue de la Paix";
        titulaire.CodePostal = "75002";
        titulaire.Ville = "Paris";
        titulaire.Telephone = "0123456789";
        titulaire.Email = "jean.dupont@example.com";

        compte.Titulaire = titulaire;
        compte.AfficherDetails();
        
        compte.crediter(500);
        compte.debiter(200);
    }
}