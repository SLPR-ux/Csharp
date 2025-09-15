public class Compte
{
    private decimal solde;

    public decimal Solde
    {
        get { return solde; }
        set { solde = value; }
    }

    public Titulaire Titulaire { get; set; }
    public void AfficherDetails()
    {
        Console.WriteLine($"Solde du compte: {solde} EUR");
        if (Titulaire != null)
        {
            Console.WriteLine("Détails du titulaire:");
            Titulaire.AfficherDetails();
        }
    }
    public void crediter(decimal montant)
    {
        if (montant > 0)
        {
            solde += montant;
            Console.WriteLine($"Crédité: {montant} EUR");
            Console.WriteLine($"Nouveau solde: {solde} EUR");
        }
        else
        {
            Console.WriteLine("Montant de crédit invalide.");
        }
    }
    public void debiter(decimal montant)
    {
        if (montant > 0 && montant <= solde)
        {
            solde -= montant;
            Console.WriteLine($"Débité: {montant} EUR");
            Console.WriteLine($"Nouveau solde: {solde} EUR");
        }
        else
        {
            Console.WriteLine("Montant de débit invalide ou solde insuffisant.");
        }
    }
}