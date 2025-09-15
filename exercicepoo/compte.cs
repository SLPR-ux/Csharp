public class Compte
{
    private decimal solde;

    public decimal Solde
    {
        get { return solde; }
        set { solde = value; }
    }
    public void AfficherDetails()
    {
        Console.WriteLine($"Solde du compte: {solde} EUR");
    }
}
public class Titulaire
{
    private int id;
    private string nom;
    private string prenom;
    private string adresse;
    private string codepostal;
    private string ville;
    private string telephone;
    private string email;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Nom
    {
        get { return nom; }
        set { nom = value; }
    }
    public string Prenom
    {
        get { return prenom; }
        set { prenom = value; }
    }
    public string Adresse
    {
        get { return adresse; }
        set { adresse = value; }
    }
    public string CodePostal
    {
        get { return codepostal; }
        set { codepostal = value; }
    }
    public string Ville
    {
        get { return ville; }
        set { ville = value; }
    }
    public string Telephone
    {
        get { return telephone; }
        set { telephone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public void AfficherDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nom: {nom}");
        Console.WriteLine($"Prénom: {prenom}");
        Console.WriteLine($"Adresse: {adresse}");
        Console.WriteLine($"Code Postal: {codepostal}");
        Console.WriteLine($"Ville: {ville}");
        Console.WriteLine($"Téléphone: {telephone}");
        Console.WriteLine($"Email: {email}");
    }
}