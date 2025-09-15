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