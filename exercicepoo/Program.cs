class Program
{
    public static void Main(string[] args)
    {
        Compte compte = new Compte();
        compte.Solde = 1500.75m;
        compte.AfficherDetails();
        
        Titulaire titulaire = new Titulaire();
        titulaire.Id = 1;
        titulaire.Nom = "Dupont";
        titulaire.Prenom = "Jean";
        titulaire.Adresse = "10 rue de la Paix";
        titulaire.CodePostal = "75002";
        titulaire.Ville = "Paris";
        titulaire.Telephone = "0123456789";
        titulaire.Email = "jean.dupont@example.com";
        titulaire.AfficherDetails();
    }
}